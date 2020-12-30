using db_projektarbeit.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CmdCustomer_Click(object sender, EventArgs e)
        {
            new CustomerView().Show();
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            new ProductView().Show();
        }

        private void CmdProductGroup_Click(object sender, EventArgs e)
        {
            new ProductGroupView().Show();
        }
    }
}
