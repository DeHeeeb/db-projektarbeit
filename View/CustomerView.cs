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
            LoadCombobox(CityControl.GetAll());
            LoadTable(CustomerControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
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
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(TxtLastName.Text) &&
                !string.IsNullOrWhiteSpace(TxtStreet.Text) &&
                CbxCity.SelectedItem != null) 
            {
                Customer customerToSave = new Customer
                {
                    Id = selected.Id,
                    CustomerNr = selected.CustomerNr,
                    FirstName = TxtFirstName.Text,
                    LastName = TxtLastName.Text,
                    CompanyName = 
                        string.IsNullOrWhiteSpace(TxtCompanyName.Text) ? 
                            null : TxtCompanyName.Text,
                    Street = TxtStreet.Text,
                    HouseNumber = 
                        string.IsNullOrWhiteSpace(TxtHouseNumber.Text) ? 
                            null : TxtHouseNumber.Text,
                    CityId = (int)CbxCity.SelectedValue
                };
                CustomerControl.Save(customerToSave);

                LoadTable(CustomerControl.GetAll());
                LoadCombobox(CityControl.GetAll());
                CbxCity.SelectedValue = selected.City.Id;
            }
        }

        private void CmdEditCity_Click(object sender, EventArgs e)
        {
            CityView cityView = new CityView();
            cityView.Show();
            cityView.Closed += RefreshCombobox;
        }

        private void RefreshCombobox(object sender, EventArgs e)
        {
            LoadCombobox(CityControl.GetAll());
            LoadTable(CustomerControl.GetAll());
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
            TxtCompanyName.Text = selected.CompanyName;
            TxtFirstName.Text = selected.FirstName;
            TxtLastName.Text = selected.LastName;
            TxtStreet.Text = selected.Street;
            TxtHouseNumber.Text = selected.HouseNumber;
            CbxCity.SelectedValue = selected.City.Id;
        }

        private void LoadTable(List<Customer> customers)
        {
            DgvCustomers.DataSource = customers;

            DgvCustomers.Columns[0].Visible = false;
            DgvCustomers.Columns[2].Visible = false;
            DgvCustomers.Columns[3].Visible = false;
            DgvCustomers.Columns[4].Visible = false;
            DgvCustomers.Columns[8].Visible = false;
            DgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
            DgvCustomers.Columns[5].HeaderText = "Name";
            DgvCustomers.Columns[6].HeaderText = "Strasse";
            DgvCustomers.Columns[7].HeaderText = "Nr";
            DgvCustomers.Columns[9].HeaderText = "PLZ / Stadt";
        }

        private void LoadCombobox(List<City> cities)
        {
            CbxCity.DisplayMember = "DisplayName";
            CbxCity.ValueMember = "Id";
            CbxCity.DataSource = cities;
        }

        private void ClearFields()
        {
            selected = new Customer();
            TxtCustomerNr.Text = "wird vergeben";
            TxtCompanyName.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtStreet.Clear();
            TxtHouseNumber.Clear();
            CbxCity.SelectedIndex = 0;
        }

        private void UnlockFields()
        {
            TxtFirstName.ReadOnly = false;
            TxtLastName.ReadOnly = false;
            TxtCompanyName.ReadOnly = false;
            TxtStreet.ReadOnly = false;
            TxtHouseNumber.ReadOnly = false;
            CbxCity.Enabled = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LockFields();
            var toDelete = CustomerControl.Delete(selected);

            if (toDelete != 0)
            {
                MessageBox.Show("Der Mitarbeiter konnte gelöscht werden.");
            }
            else
            {
                MessageBox.Show("Verlinkte Aufträge gefunden. Bitte löschen Sie diese zuerst.");
            }

            UnlockFields();
            LoadTable(CustomerControl.GetAll());
        }

        private void LockFields()
        {
            TxtCompanyName.ReadOnly = true;
            TxtFirstName.ReadOnly = true;
            TxtLastName.ReadOnly = true;
            TxtStreet.ReadOnly = true;
            TxtHouseNumber.ReadOnly = true;
            CbxCity.Enabled = false;
        }
    }
}
