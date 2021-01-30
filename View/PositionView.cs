using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;

namespace db_projektarbeit.View
{
    public partial class PositionView : Form
    {
        ProductControl ProductControl = new ProductControl();
        Position selected = new Position();
        List<Position> allPositions = new List<Position>();
        
        public PositionView(List<Position> positions)
        {
            allPositions = positions;
            InitializeComponent();
            LoadCombobox(ProductControl.GetAll());
            LoadTable(allPositions);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            // todo
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            UnlockFields();
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
            LoadTable(allPositions);
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
            DgvPositions.Columns[3].Visible = false;
            DgvPositions.Columns[4].Visible = false;
            DgvPositions.Columns[5].Visible = false;
            DgvPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPositions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvPositions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvPositions.Columns[1].HeaderText = "Anzahl";
            DgvPositions.Columns[2].HeaderText = "Preis";
            DgvPositions.Columns[6].HeaderText = "Produkt";
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
    }
}
