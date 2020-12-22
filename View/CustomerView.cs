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
    public partial class CustomerView : Form
    {
        CustomerControl CustomerControl = new CustomerControl();
        CityControl CityControl = new CityControl();
        Customer selected = new Customer();

        public CustomerView()
        {
            InitializeComponent();
            LoadTable(CustomerControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (String.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(CustomerControl.GetAll());
            } else
            {
                LoadTable(CustomerControl.Search(searchText));
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
            if (!String.IsNullOrWhiteSpace(TxtName.Text) && 
                !String.IsNullOrWhiteSpace(TxtStreet.Text) &&
                !String.IsNullOrWhiteSpace(TxtCity.Text))
            {
                City cityToSave = new City
                {
                    Id = selected.CityId,
                    Zip = (int)NumZip.Value,
                    Name = TxtCity.Text
                };
                int cityId = CityControl.Save(cityToSave);

                Customer customerToSave = new Customer
                {
                    Id = selected.Id,
                    CustomerNr = selected.CustomerNr,
                    Name = TxtName.Text,
                    Street = TxtStreet.Text,
                    CityId = cityId
                };
                CustomerControl.Save(customerToSave);

                LoadTable(CustomerControl.GetAll());
            }
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var rows = DgvCustomers.SelectedRows;
            DataGridViewRow row;
            if (rows.Count == 0 && DgvCustomers.SelectedCells.Count == 1)
            {
                row = DgvCustomers.SelectedCells[0].OwningRow;
            } else if (rows.Count == 1)
            {
                row = rows[0];
            } else
            {
                return;
            }

            UnlockFields();

            selected = (Customer) row.DataBoundItem;
            TxtCustomerNr.Text = selected.CustomerNr.ToString();
            TxtName.Text = selected.Name;
            TxtStreet.Text = selected.Street;
            NumZip.Value = selected.City.Zip;
            TxtCity.Text = selected.City.Name;
        }

        private void LoadTable(List<Customer> customers)
        {
            DgvCustomers.DataSource = customers;

            DgvCustomers.Columns[0].Visible = false;
            DgvCustomers.Columns[4].Visible = false;
            DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
            DgvCustomers.Columns[2].HeaderText = "Name";
            DgvCustomers.Columns[3].HeaderText = "Strasse / Nr";
            DgvCustomers.Columns[5].HeaderText = "PLZ / Stadt";
        }

        private void ClearFields()
        {
            selected = new Customer();
            TxtCustomerNr.Text = "wird vergeben";
            TxtName.Clear();
            TxtStreet.Clear();
            NumZip.ResetText();
            TxtCity.Clear();
        }

        private void UnlockFields()
        {
            TxtName.ReadOnly = false;
            TxtStreet.ReadOnly = false;
            NumZip.ReadOnly = false;
            TxtCity.ReadOnly = false;
        }
    }
}
