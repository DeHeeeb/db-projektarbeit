using db_projektarbeit.Control;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class OrderView : Form
    {
        private OrderControl OrderControl = new OrderControl();
        private CustomerControl CustomerControl = new CustomerControl();
        private Order selected = new Order();

        public OrderView()
        {
            InitializeComponent();
            LoadOrderTable(OrderControl.GetAll());
            LoadCombobox(CustomerControl.GetAll());
            LoadTotal();
        }

        private void LoadOrderTable(List<Order> orders)
        {
            DgvOrder.DataSource = orders;

            DgvOrder.Columns[0].Visible = false;
            DgvOrder.Columns[2].Visible = false;
            DgvOrder.Columns[3].Visible = false;
            DgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvOrder.Columns[1].HeaderText = "Datum";
            DgvOrder.Columns[4].HeaderText = "Kunde";
        }

        private void LoadPositionTable(List<Position> positions)
        {
            if (positions != null)
            {
                DgvPosition.DataSource = positions;

                DgvPosition.Columns[0].Visible = false;
                DgvPosition.Columns[3].Visible = false;
                DgvPosition.Columns[4].Visible = false;
                DgvPosition.Columns[5].Visible = false;
                DgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvPosition.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvPosition.Columns[1].HeaderText = "Anzahl";
                DgvPosition.Columns[2].HeaderText = "Preis";
                DgvPosition.Columns[6].HeaderText = "Produkt";
            }
        }

        private void LoadCombobox(List<Customer> customers)
        {
            CbxCustomer.DisplayMember = "FullName";
            CbxCustomer.ValueMember = "Id";
            CbxCustomer.DataSource = customers;
        }

        private void LoadTotal()
        {
            if (selected.Positions != null)
            {
                NumTotal.Value = selected.Positions.Sum(p => p.Total);
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadOrderTable(OrderControl.GetAll());
            }
            else
            {
                LoadOrderTable(OrderControl.Search(searchText));
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

        private void CmdEditPositions_Click(object sender, EventArgs e)
        {

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (DtpDate.Value != null &&
                CbxCustomer.SelectedItem != null)
            {
                Order orderToSave = new Order()
                {
                    Id = selected.Id,
                    Date = DtpDate.Value,
                    Comment = 
                        string.IsNullOrWhiteSpace(TxtComment.Text) ? 
                            null : TxtComment.Text,
                    CustomerId = (int) CbxCustomer.SelectedValue
                };
                OrderControl.Save(orderToSave);

                LoadOrderTable(OrderControl.GetAll());
                LoadCombobox(CustomerControl.GetAll());
                LoadTotal();
                CbxCustomer.SelectedValue = selected.Customer.Id;
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            UnlockFields();
            ClearFields();
            LoadPositionTable(new List<Position>());
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

            UnlockFields();

            selected = (Order) row.DataBoundItem;
            LoadPositionTable(selected.Positions);
            LoadTotal();
            DtpDate.Value = selected.Date;
            CbxCustomer.SelectedValue = selected.Customer.Id;
            TxtComment.Text = selected.Comment;
        }

        private void CmdEditCustomer_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.Show();
            customerView.Closed += RefreshCombobox;
        }

        private void RefreshCombobox(object sender, EventArgs e)
        {
            LoadCombobox(CustomerControl.GetAll());
            LoadOrderTable(OrderControl.GetAll());
        }

        private void UnlockFields()
        {
            DtpDate.Enabled = true;
            CbxCustomer.Enabled = true;
            TxtComment.ReadOnly = false;
        }

        private void ClearFields()
        {
            selected = new Order();
            DtpDate.Value = DateTime.Now.Date;
            CbxCustomer.SelectedIndex = 0;
            TxtComment.Clear();
        }
    }
}
