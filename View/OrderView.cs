﻿using db_projektarbeit.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class OrderView : Form
    {
        OrderControl OrderControl = new OrderControl();

        public OrderView()
        {
            InitializeComponent();
            LoadTable(OrderControl.GetAll());
        }

        private void LoadTable(List<Order> orders)
        {
            DgvOrder.DataSource = orders;

            DgvOrder.Columns[0].Visible = false;
            DgvOrder.Columns[3].Visible = false;
            DgvOrder.Columns[1].HeaderText = "Kunden-Nr";
            DgvOrder.Columns[2].HeaderText = "Name";
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {

        }
    }
}