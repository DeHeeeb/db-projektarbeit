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
        private BindingSource bindingSourceOder = new BindingSource();
        private BindingSource bindingSourceOderPosition = new BindingSource();

        public OrderView()
        {
            InitializeComponent();
            LoadTable(OrderControl.GetAll());
        }

        private void LoadTable(List<Order> orders)
        {
            orders.ForEach(o => bindingSourceOder.Add(o));
            DgvOrder.DataSource = bindingSourceOder;


            //DgvOrder.Columns[0].Visible = false;
            //DgvOrder.Columns[3].Visible = false;

            //DgvOrder.Columns[1].HeaderText = "Datum";
            //DgvOrder.Columns[2].HeaderText = "Kommentar";
            //DgvOrder.Columns[4].HeaderText = "Kunde";
            //DgvOrder.Columns[5].HeaderText = "Positionen";
            //var temp = DgvOrder.Columns[5].Displayed;




            //DataGridViewOderMapper(orders);
        }

        //private DataTable DataGridViewOderMapper(List<Order> orders)
        //{
        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("Datum", typeof(DateTime));
        //    dt.Columns.Add("Kommentar", typeof(string));
        //    dt.Columns.Add("Kunde", typeof(string));
        //    dt.Columns.Add("Anzahl-Artikel", typeof(int));

        //    foreach (var item in orders)
        //    {
        //        dt.Rows.Add(item.Id, item.Date, item.Comment, item.Customer.Name, item.Positions.Count);
        //    }

        //    return dt;
        //}

        private void CmdSearch_Click(object sender, EventArgs e)
        {

        }

        private void DgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            var selected = (DataGridView) sender;
            
            DataGridViewRow row;
            if (selected.SelectedRows.Count == 0 && selected.SelectedCells.Count == 1)
            {
                row = selected.SelectedCells[0].OwningRow;
            }
            else if (selected.SelectedRows.Count == 1)
            {
                row = selected.Rows[0];
            }
            else
            {
                return;
            }

            bindingSourceOderPosition.Clear();

            var selectOder = (Order)row.DataBoundItem;

            foreach (var item in selectOder.Positions)
            {
                bindingSourceOderPosition.Add(item);
            }

            DgvOrderPos.DataSource = bindingSourceOderPosition;

            DgvOrderPos.Columns[3].Visible = false;
            DgvOrderPos.Columns[4].Visible = false;

            DgvOrderPos.Columns[0].HeaderText = "Position";
            DgvOrderPos.Columns[1].HeaderText = "Anzahl";

        }
    }
}
