using db_projektarbeit.Control;
using db_projektarbeit.View.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class CustomerView : Form
    {
        readonly Regex EmailRegex = new Regex(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$", RegexOptions.IgnoreCase);
        readonly Regex WebsiteRegex = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$", RegexOptions.IgnoreCase);
        readonly Regex PasswordRegex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");

        private readonly CustomerControl CustomerControl = new CustomerControl();
        private readonly CityControl CityControl = new CityControl();
        private Customer selected = new Customer();

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
            EnterSaveMode();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword(TxtPassword.Text))
            {
                MessageBox.Show(MessageBoxConstants.TextPassword,
                MessageBoxConstants.CaptionError,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            if (!string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                if (!ValidateEmail(TxtEmail.Text))
                {
                    MessageBox.Show(MessageBoxConstants.TextEmail,
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

            if (!string.IsNullOrWhiteSpace(TxtWebsite.Text))
            {
                if (!ValidateWebsite(TxtWebsite.Text))
                {
                    MessageBox.Show(MessageBoxConstants.TextWebsite,
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }


            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(TxtLastName.Text) &&
                !string.IsNullOrWhiteSpace(TxtStreet.Text) &&
                !string.IsNullOrWhiteSpace(TxtPassword.Text) &&
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
                    Email = TxtEmail.Text,
                    Website = TxtWebsite.Text,
                    Password = TxtPassword.Text,
                    CityId = (int)CbxCity.SelectedValue
                };
                CustomerControl.Save(customerToSave);

                LoadTable(CustomerControl.GetAll());
                LoadCombobox(CityControl.GetAll());
                CbxCity.SelectedValue = selected.City.Id;
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
            TxtCustomerNr.Text = "CU"+selected.CustomerNr.ToString();
            TxtCompanyName.Text = selected.CompanyName;
            TxtFirstName.Text = selected.FirstName;
            TxtLastName.Text = selected.LastName;
            TxtStreet.Text = selected.Street;
            TxtHouseNumber.Text = selected.HouseNumber;
            TxtEmail.Text = selected.Email;
            TxtWebsite.Text = selected.Website;
            TxtPassword.Text = selected.Password;
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
            DgvCustomers.Columns[10].Visible = false;
            DgvCustomers.Columns[11].Visible = false;
            DgvCustomers.Columns[12].Visible = false;
            DgvCustomers.Columns[13].Visible = false;
            DgvCustomers.Columns[14].Visible = false;
            DgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
            DgvCustomers.Columns[5].HeaderText = "Name";
            DgvCustomers.Columns[6].HeaderText = "Strasse";
            DgvCustomers.Columns[7].HeaderText = "Nr";
            DgvCustomers.Columns[9].HeaderText = "PLZ / Stadt";
            DgvCustomers.Columns[1].DefaultCellStyle.Format = "CU0";
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
            TxtEmail.Clear();
            TxtWebsite.Clear();
            TxtPassword.Clear();
            CbxCity.SelectedIndex = 0;
        }

        private void UnlockFields()
        {
            TxtFirstName.ReadOnly = false;
            TxtLastName.ReadOnly = false;
            TxtCompanyName.ReadOnly = false;
            TxtStreet.ReadOnly = false;
            TxtHouseNumber.ReadOnly = false;
            TxtEmail.ReadOnly = false;
            TxtWebsite.ReadOnly = false;
            TxtPassword.ReadOnly = false;
            CbxCity.Enabled = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

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
                var toDelete = CustomerControl.Delete(selected);
                if (toDelete != 0)
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextSuccessDelete,"Der Kunde"),
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
                MessageBox.Show(MessageBoxConstants.TextNotDeleted,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            TxtEmail.ReadOnly = true;
            TxtWebsite.ReadOnly = true;
            TxtPassword.ReadOnly = true;
            CbxCity.Enabled = false;
        }

        private void EnterSaveMode()
        {
            CmdSave.BackColor = Color.MediumSeaGreen;
            CmdDelete.Enabled = false;
            CmdNew.Enabled = false;
            TxtSearch.Enabled = false;
            CmdSearch.Enabled = false;
            TxtCompanyName.Focus();
        }

        private void EndSaveMode()
        {
            CmdSave.BackColor = Color.Gainsboro;
            CmdDelete.Enabled = true;
            CmdNew.Enabled = true;
            TxtSearch.Enabled = true;
            CmdSearch.Enabled = true;
        }

        public bool ValidateEmail(String email)
        {
            if (EmailRegex.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        public bool ValidateWebsite(String website)
        {
            if (WebsiteRegex.IsMatch(website))
            {
                return true;
            }
            return false;
        }

        public bool ValidatePassword(String password)
        {
            if (PasswordRegex.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }
}
