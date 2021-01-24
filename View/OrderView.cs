using db_projektarbeit.Control;
using System;
using System.CodeDom.Compiler;
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
        private OrderControl OrderControl = new OrderControl();
        private Order selected = new Order();

        public OrderView()
        {
            InitializeComponent();
            LoadOrderTable(OrderControl.GetAll());
        }

        private void LoadOrderTable(List<Order> orders)
        {
            DgvOrder.DataSource = orders;

            DgvOrder.Columns[0].Visible = false;
            DgvOrder.Columns[2].Visible = false;
            DgvOrder.Columns[3].Visible = false;
            //DgvOrder.Columns[5].Visible = false;
            DgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvOrder.Columns[1].HeaderText = "Datum";
            DgvOrder.Columns[4].HeaderText = "Kunde";
        }

        private void LoadPositionTable(List<Position> positions)
        {
            DgvPosition.DataSource = positions;
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {

        }

        private void DgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            var rows = DgvOrder.SelectedRows;
            DataGridViewRow row;
            if (rows.Count == 0 && DgvOrder.SelectedCells.Count == 1)
            {
                row = DgvOrder.SelectedCells[0].OwningRow;
            }
            else if (rows.Count == 1)
            {
                row = rows[0];
            }
            else
            {
                return;
            }

            selected = (Order) row.DataBoundItem;
            LoadPositionTable(selected.Positions);
        }
    }
}
