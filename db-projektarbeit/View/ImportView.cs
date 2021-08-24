using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;
using db_projektarbeit.Data.Export;
using db_projektarbeit.Data.Import;
using db_projektarbeit.View.Common;

namespace db_projektarbeit.View
{
    public partial class ImportView : Form
    {
        private string path;
        private List<Customer> customers;
        private readonly CustomerControl _customerControl = new CustomerControl();
        private CustomerImport _customerImport;

        public ImportView()
        {
            InitializeComponent();
            customers = new List<Customer>();
        }

        private void CmdOfd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Export files (*.xml;*.json)|*.xml;*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    TxtPath.Text = path.ToString();

                    string extension = Path.GetExtension(openFileDialog.FileName);

                    if (extension == ".xml")
                    {
                        _customerImport = new CustomerImport(path, new XmlImportStrategy());
                        
                    }
                    else if (extension == ".json")
                    {
                        _customerImport = new CustomerImport(path, new JsonImportStrategy());
                    }

                    var _customers = _customerImport.GetCustomers();



                    foreach (var customer in _customers)
                    {
                        customer.City = null;
                        customers.Add(customer);
                    }

                    LoadTable(customers);
                }
            }
        }

        private void CmdImport_Click(object sender, EventArgs e)
        {
            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    _customerControl.Save(customer);
                }

                MessageBox.Show(MessageBoxConstants.TextImportSuccessful,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void LoadTable(List<Customer> customers)
        {
            DgvCustomers.DataSource = customers;

            DgvCustomers.Columns[0].Visible = false;
            DgvCustomers.Columns[2].Visible = false;
            DgvCustomers.Columns[3].Visible = false;
            DgvCustomers.Columns[4].Visible = false;
            DgvCustomers.Columns[8].Visible = false;
            DgvCustomers.Columns[9].Visible = false;
            DgvCustomers.Columns[10].Visible = false;
            DgvCustomers.Columns[11].Visible = false;
            DgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
            DgvCustomers.Columns[5].HeaderText = "Name";
            DgvCustomers.Columns[6].HeaderText = "Strasse";
            DgvCustomers.Columns[7].HeaderText = "Nr";
        }
    }
}
