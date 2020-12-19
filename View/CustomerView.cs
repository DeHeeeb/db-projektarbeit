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
    public partial class CustomerView : Form
    {
        CustomerControl CustomerControl = new CustomerControl();

        public CustomerView()
        {
            InitializeComponent();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            Customer cu = CustomerControl.GetById(1);
            TxtCustomerNr.Text = cu.CustomerNr.ToString();
            TxtName.Text = cu.Name;
            TxtStreet.Text = cu.Street;
        }
    }
}
