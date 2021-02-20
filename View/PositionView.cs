using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;
using db_projektarbeit.View.Common;

namespace db_projektarbeit.View
{
    public partial class PositionView : Form
    {
        PositionControl PositionControl = new PositionControl();
        ProductControl ProductControl = new ProductControl();
        Position selected = new Position();
        Order parentOrder;
        
        public PositionView(Order order)
        {
            parentOrder = order;
            InitializeComponent();
            LoadTable(PositionControl.GetAllByOrderId(parentOrder.Id));
            LoadCombobox(ProductControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(PositionControl.GetAllByOrderId(parentOrder.Id));
            }
            else
            {
                LoadTable(PositionControl.Search(searchText, parentOrder.Id));
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
            NumCount.Focus();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (NumCount.Value != 0 &&
                CbxProduct.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(CbxProduct.Text))
            {
                Position positionToSave = new Position()
                {
                    Id = selected.Id,
                    Count = (int)NumCount.Value,
                    OrderId = parentOrder.Id,
                    ProductId = (int)CbxProduct.SelectedValue
                };

                PositionControl.Save(positionToSave);

                LoadTable(PositionControl.GetAllByOrderId(parentOrder.Id));
                LoadCombobox(ProductControl.GetAll());
                CbxProduct.SelectedValue = selected.Product.Id;
            }
            else
            {
                MessageBox.Show(MessageBoxConstants.TextMissingFormInfo,
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CmdEditProduct_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();
            productView.Show();
            productView.Closed += RefreshCombobox;
        }

        private void RefreshCombobox(object sender, EventArgs e)
        {
            LoadCombobox(ProductControl.GetAll());
            LoadTable(PositionControl.GetAllByOrderId(parentOrder.Id));
        }

        private void DgvPositions_SelectionChanged(object sender, EventArgs e)
        {
            var rows = DgvPositions.SelectedRows;
            DataGridViewRow row;
            if (rows.Count == 0 && DgvPositions.SelectedCells.Count == 1)
            {
                row = DgvPositions.SelectedCells[0].OwningRow;
            }
            else if (rows.Count == 1)
            {
                row = rows[0];
            }
            else
            {
                return;
            }

            UnlockFields();

            selected = (Position)row.DataBoundItem;
            NumCount.Value = selected.Count;
            CbxProduct.SelectedValue = selected.Product.Id;
        }

        private void LoadTable(List<Position> positions)
        {
            DgvPositions.DataSource = positions;

            DgvPositions.Columns[0].Visible = false;
            DgvPositions.Columns[2].Visible = false;
            DgvPositions.Columns[3].Visible = false;
            DgvPositions.Columns[4].Visible = false;
            DgvPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPositions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvPositions.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvPositions.Columns[1].HeaderText = "Anzahl";
            DgvPositions.Columns[5].HeaderText = "Produkt";
            DgvPositions.Columns[6].HeaderText = "Preis";
        }

        private void LoadCombobox(List<Product> products)
        {
            CbxProduct.DisplayMember = "DisplayName";
            CbxProduct.ValueMember = "Id";
            CbxProduct.DataSource = products;
        }

        private void ClearFields()
        {
            selected = new Position();
            NumCount.Value = NumCount.Minimum;
            CbxProduct.ResetText();
        }

        private void UnlockFields()
        {
            NumCount.ReadOnly = false;
            CbxProduct.Enabled = true;
        }

        private void LockFields()
        {
            NumCount.ReadOnly = true;
            CbxProduct.Enabled = false;
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
                var toDelete = PositionControl.Delete(selected);
                if (toDelete != 0)
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextSuccessDelete, "Die Position"),
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MessageBoxConstants.TextNotDeleted,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(MessageBoxConstants.TextNotDeleted,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            UnlockFields();
            LoadTable(PositionControl.GetAllByOrderId(parentOrder.Id));
        }
    }
}
