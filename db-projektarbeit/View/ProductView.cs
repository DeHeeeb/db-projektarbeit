using db_projektarbeit.Control;
using db_projektarbeit.View.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit.View
{
    public partial class ProductView : Form
    {
        private IServiceProvider _provider;
        private readonly ProductControl _productControl;
        private readonly ProductGroupControl _productGroupControl;
        private Product selected = new Product();

        public ProductView(ProductControl productControl, ProductGroupControl productGroupControl)
        {
            _productControl = productControl;
            _productGroupControl = productGroupControl;
            InitializeComponent();
            LoadTable(_productControl.GetAll());
            var arrayNodes = _productGroupControl.ConvertToTreeNodes(_productGroupControl.GetAll());
            LoadTreeView(arrayNodes);
        }

        public void SetProvider(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void LoadTreeView(TreeNode[] treeNodes)
        {
            TvProductGroup.Nodes.AddRange(treeNodes);
            TvProductGroup.ExpandAll();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(_productControl.GetAll());
            } else
            {
                LoadTable(_productControl.Search(searchText));
            }
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmdSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            UnlockFields();
            EnterSaveMode();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtDescription.Text) && 
                NumPrice.Value != 0 &&
                TvProductGroup.SelectedNode != null)
            {
                Product productToSave = new Product
                {
                    Id = selected.Id,
                    ProductNr = selected.ProductNr,
                    Description = TxtDescription.Text,
                    Price = NumPrice.Value,
                    GroupId = Convert.ToInt32(TvProductGroup.SelectedNode.Name)
                };
                _productControl.Save(productToSave);

                LoadTable(_productControl.GetAll());
                EndSaveMode();
            }
            else
            {
                MessageBox.Show(MessageBoxConstants.TextMissingFormInfo,
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var rows = DgvProducts.SelectedRows;
            DataGridViewRow row;
            if (rows.Count == 0 && DgvProducts.SelectedCells.Count == 1)
            {
                row = DgvProducts.SelectedCells[0].OwningRow;
            } else if (rows.Count == 1)
            {
                row = rows[0];
            } else
            {
                return;
            }

            UnlockFields();

            selected = (Product) row.DataBoundItem;
            TxtProductNr.Text = selected.ProductNr.ToString();
            TxtDescription.Text = selected.Description;
            NumPrice.Value = selected.Price;
            TvProductGroup.SelectedNode = TvProductGroup.Nodes.Find(selected.Group.Id.ToString(), true)[0];
            TvProductGroup.Select();
        }

        private void LoadTable(List<Product> products)
        {
            DgvProducts.DataSource = products;

            DgvProducts.Columns[0].Visible = false;
            DgvProducts.Columns[2].Visible = false;
            DgvProducts.Columns[6].Visible = false;
            DgvProducts.Columns[7].Visible = false;
            DgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProducts.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProducts.Columns[1].HeaderText = "Artikel-Nr";
            DgvProducts.Columns[3].HeaderText = "Artikelgruppe";
            DgvProducts.Columns[4].HeaderText = "Beschreibung";
            DgvProducts.Columns[5].HeaderText = "Preis";
        }

        private void ClearFields()
        {
            selected = new Product();
            TxtProductNr.Text = "wird vergeben";
            TxtDescription.Clear();
            NumPrice.Value = 0;
            TvProductGroup.SelectedNode = null;
        }

        private void UnlockFields()
        {
            TxtDescription.ReadOnly = false;
            NumPrice.ReadOnly = false;
            TvProductGroup.Enabled = true;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LockFields();

            DialogResult dialogResult = MessageBox.Show(MessageBoxConstants.TextQuestionSureToDelete,
                MessageBoxConstants.CaptionQuestion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var toDelete = _productControl.Delete(selected);
                if (toDelete != 0)
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextSuccessDelete, "Der Artikel"),
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextErrorDeleteBecauseLink, "Aufträge"),
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(string.Format(MessageBoxConstants.TextErrorDeleteBecauseLink, "Aufträge"),
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            UnlockFields();
            LoadTable(_productControl.GetAll());
        }

        private void LockFields()
        {
            TxtDescription.ReadOnly = true;
            NumPrice.ReadOnly = true;
            TvProductGroup.Enabled = false;
        }

        private void EnterSaveMode()
        {
            CmdSave.BackColor = Color.MediumSeaGreen;
            CmdDelete.Enabled = false;
            CmdNew.Enabled = false;
            TxtSearch.Enabled = false;
            CmdSearch.Enabled = false;
            TxtDescription.Focus();
        }

        private void EndSaveMode()
        {
            CmdSave.BackColor = Color.Gainsboro;
            CmdDelete.Enabled = true;
            CmdNew.Enabled = true;
            TxtSearch.Enabled = true;
            CmdSearch.Enabled = true;
        }

        private void CmdEditProductGroup_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<ProductGroupView>();
            view.Show();
        }
    }
}
