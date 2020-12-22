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
        Product selected = new Product();

        public ProductView()
        {
            InitializeComponent();
            LoadTable(ProductControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (String.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(ProductControl.GetAll());
            } else
            {
                //LoadTable(ProductControl.Search(searchText));
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
            if (!String.IsNullOrWhiteSpace(TxtDescription.Text) && 
                !String.IsNullOrWhiteSpace(TxtPrice.Text))
            {
                Product productToSave = new Product
                {
                    Id = selected.Id,
                    ProductNr = selected.ProductNr,
                    GroupId = selected.GroupId,
                    Description = TxtDescription.Text,
                    //Price = TxtPrice.Text,
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
            TxtPrice.Text = selected.Price.ToString();
        }

        private void LoadTable(List<Product> products)
        {
            DgvProducts.DataSource = products;

            DgvProducts.Columns[0].Visible = false;
            DgvProducts.Columns[2].Visible = false;
            DgvProducts.Columns[1].HeaderText = "Produkt-Nr";
            DgvProducts.Columns[3].HeaderText = "Produktgruppe";
            DgvProducts.Columns[4].HeaderText = "Beschreibung";
            DgvProducts.Columns[5].HeaderText = "Preis";
        }

        private void ClearFields()
        {
            selected = new Product();
            TxtProductNr.Text = "wird vergeben";
            TxtDescription.Clear();
            TxtPrice.Clear();
        }

        private void UnlockFields()
        {
            TxtDescription.ReadOnly = false;
            TxtPrice.ReadOnly = false;
        }
    }
}
