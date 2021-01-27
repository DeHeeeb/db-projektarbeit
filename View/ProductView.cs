using db_projektarbeit.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class ProductView : Form
    {
        ProductControl ProductControl = new ProductControl();
        ProductGroupControl ProductGroupControl = new ProductGroupControl();
        Product selected = new Product();

        public ProductView()
        {
            InitializeComponent();
            LoadTable(ProductControl.GetAll());
            var arrayNodes = ProductGroupControl.ConvertToTreeNodes(ProductGroupControl.GetAll());
            LoadTreeView(arrayNodes);
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
                LoadTable(ProductControl.GetAll());
            } else
            {
                LoadTable(ProductControl.Search(searchText));
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
                ProductControl.Save(productToSave);

                LoadTable(ProductControl.GetAll());
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
    }
}
