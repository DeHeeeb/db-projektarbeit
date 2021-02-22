using System;
using System.Collections.Generic;
using System.Windows.Forms;
using db_projektarbeit.Control;

namespace db_projektarbeit.View
{
    public partial class BillView : Form
    {
        BillControl BillControl = new BillControl();

        public BillView()
        {
            InitializeComponent();
            LoadTable(BillControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(BillControl.GetAll());
            }
            else
            {
                LoadTable(BillControl.Search(searchText));
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
        
        private void LoadTable(List<Bill> bills)
        {
            DgvBills.DataSource = bills;

            DgvBills.Columns[0].Visible = false;
            DgvBills.Columns[9].Visible = false;
            DgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBills.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvBills.Columns[1].HeaderText = "Abrechnungsdatum";
            DgvBills.Columns[2].HeaderText = "Rechnungs-Nr";
            DgvBills.Columns[3].HeaderText = "Kunden-Nr";
            DgvBills.Columns[4].HeaderText = "Kunde";
            DgvBills.Columns[5].HeaderText = "Strasse";
            DgvBills.Columns[6].HeaderText = "Nr";
            DgvBills.Columns[7].HeaderText = "Stadt";
            DgvBills.Columns[8].HeaderText = "Land";
            DgvBills.Columns[10].HeaderText = "Brutto";
            DgvBills.Columns[11].HeaderText = "Netto";
        }
    }
}
