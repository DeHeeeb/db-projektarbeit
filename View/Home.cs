using db_projektarbeit.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace db_projektarbeit.View
{
    public partial class Home : Form
    {
        HomeControl homeControl = new HomeControl();

        public Home()
        {
            InitializeComponent();
        }

        private void CmdCustomer_Click(object sender, EventArgs e)
        {
            new CustomerView().Show();
        }

        private void CmdCity_Click(object sender, EventArgs e)
        {
            new CityView().Show();
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            new ProductView().Show();
        }

        private void CmdProductGroup_Click(object sender, EventArgs e)
        {
            new ProductGroupView().Show();
        }

        private void CmdOrder_Click(object sender, EventArgs e)
        {
            new OrderView().Show();
        }

        private void CmdBill_Click(object sender, EventArgs e)
        {
            new BillView().Show();
        }
        private void CmdStatistics_Click(object sender, EventArgs e)
        {
            new StatisticsView().Show();
        }

        private void TimerSQLCheck_Tick(object sender, EventArgs e)
        {
            var sqlCheck = homeControl.GetStatusSQL();
            if (sqlCheck)
            {
                LblSQLCheck.Text = "SQL Server Verbunden";
                CmdBill.Enabled = true;
                CmdCity.Enabled = true;
                CmdCustomer.Enabled = true;
                CmdOrder.Enabled = true;
                CmdOrder.BackColor = Color.MediumSeaGreen;
                CmdProduct.Enabled = true;
                CmdProductGroup.Enabled = true;
                CmdStatistics.Enabled = true;
            }
            else
            {
                LblSQLCheck.Text = "SQL Server nicht Verbunden";
            }
        }


    }
}
