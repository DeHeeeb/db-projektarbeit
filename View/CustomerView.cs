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

        public CustomerView()
        {
            InitializeComponent();
            DgvCustomers.DataSource = CustomerControl.GetAll();
            DgvCustomers.Columns[0].Visible = false;
            DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
            DgvCustomers.Columns[2].HeaderText = "Name";
            DgvCustomers.Columns[3].HeaderText = "Strasse";
            DgvCustomers.Columns[4].HeaderText = "PLZ / Stadt";
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            Customer cu = CustomerControl.GetById(1);
            TxtCustomerNr.Text = cu.CustomerNr.ToString();
            TxtName.Text = cu.Name;
            TxtStreet.Text = cu.Street;
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

            Customer selected = (Customer) row.DataBoundItem;
            TxtCustomerNr.Text = selected.CustomerNr.ToString();
            TxtName.Text = selected.Name;
            TxtStreet.Text = selected.Street;
            TxtZip.Text = selected.City.Zip.ToString();
            TxtCity.Text = selected.City.Name;
        }
    }
}
