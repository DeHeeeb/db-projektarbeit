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
        private CityControl CityControl = new CityControl();

        public Home()
        {
            InitializeComponent();
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form11 = new CustomerView();
            form11.Show();
        }
    }
}
