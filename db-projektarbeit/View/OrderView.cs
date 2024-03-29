﻿using db_projektarbeit.Control;
using db_projektarbeit.View.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit.View
{
    public partial class OrderView : Form
    {
        private IServiceProvider _provider;
        private readonly OrderControl _orderControl;
        private readonly CustomerControl _customerControl;
        private readonly BillControl _billControl;
        private Order selected = new Order();

        public OrderView(OrderControl orderControl, CustomerControl customerControl, BillControl billControl)
        {
            _orderControl = orderControl;
            _customerControl = customerControl;
            _billControl = billControl;
            InitializeComponent();
            LoadOrderTable(_orderControl.GetAll());
            LoadCombobox(_customerControl.GetAll());
            LoadTotal();
        }

        public void SetProvider(IServiceProvider provider)
        {
            _provider = provider;
        }

        private void LoadOrderTable(List<Order> orders)
        {
            DgvOrder.DataSource = orders;

            DgvOrder.Columns[0].Visible = false;
            DgvOrder.Columns[3].Visible = false;
            DgvOrder.Columns[4].Visible = false;
            DgvOrder.Columns[6].Visible = false;
            DgvOrder.Columns[7].Visible = false;
            DgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvOrder.Columns[1].HeaderText = "Datum";
            DgvOrder.Columns[2].HeaderText = "Auftrags-Nr";
            DgvOrder.Columns[4].HeaderText = "Kunde";
        }

        private void LoadPositionTable(List<Position> positions)
        {
            if (positions != null)
            {
                DgvPosition.DataSource = positions;

                DgvPosition.Columns[0].Visible = false;
                DgvPosition.Columns[2].Visible = false;
                DgvPosition.Columns[3].Visible = false;
                DgvPosition.Columns[4].Visible = false;
                DgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvPosition.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvPosition.Columns[1].HeaderText = "Anzahl";
                DgvPosition.Columns[5].HeaderText = "Produkt";
                DgvPosition.Columns[6].HeaderText = "Preis";
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
                NumTotal.Value = selected.Total;
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadOrderTable(_orderControl.GetAll());
            }
            else
            {
                LoadOrderTable(_orderControl.Search(searchText));
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
            if (selected.Id != 0)
            {
                var view = _provider.GetRequiredService<PositionView>();
                view.SetSelected(selected);
                view.SetProvider(_provider);
                view.Show();
                view.Closed += Refresh;
            }
            else
            {
                MessageBox.Show(MessageBoxConstants.TextMissingOrderEntity,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (!selected.Billed)
            {
                if (DtpDate.Value != null &&
                    CbxCustomer.SelectedItem != null)
                {
                    Order orderToSave = new Order()
                    {
                        Id = selected.Id,
                        OrderNr = selected.OrderNr,
                        Date = DtpDate.Value,
                        Comment =
                            string.IsNullOrWhiteSpace(TxtComment.Text) ?
                                null : TxtComment.Text,
                        CustomerId = (int) CbxCustomer.SelectedValue
                    };
                    _orderControl.Save(orderToSave);

                    LoadOrderTable(_orderControl.GetAll());
                    LoadCombobox(_customerControl.GetAll());
                    LoadTotal();
                    CbxCustomer.SelectedValue = selected.Customer.Id;
                    EndSaveMode();
                }
                else
                {
                    MessageBox.Show(MessageBoxConstants.TextMissingFormInfo,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            UnlockFields();
            ClearFields();
            LoadPositionTable(new List<Position>());
            EnterSaveMode();
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
            if (selected.Billed)
            {
                CmdBill.Enabled = false;
                CmdBill.ForeColor = Color.ForestGreen;
            }
            else
            {
                CmdBill.Enabled = true;
                CmdBill.ForeColor = Color.Black;
            }
        }

        private void CmdEditCustomer_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<CustomerView>();
            view.SetProvider(_provider);
            view.Show();
            view.Closed += Refresh;
        }

        private void CmdBill_Click(object sender, EventArgs e)
        {
            if (!selected.Billed && 
                DtpDate.Value != null &&
                CbxCustomer.SelectedItem != null)
            {
                if (selected.Total > 0)
                {
                    _orderControl.Bill(selected.Id);

                    var billToSave = new Bill
                    {
                        Date = DateTime.Now,
                        CustomerId = selected.CustomerId,
                        Netto = selected.Total
                    };
                    _billControl.Save(billToSave);

                    MessageBox.Show(MessageBoxConstants.TextOrderBilled,
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadOrderTable(_orderControl.GetAll());
                }
                else
                {
                    MessageBox.Show(MessageBoxConstants.TextOrderTotalNotSet,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Refresh(object sender, EventArgs e)
        {
            LoadCombobox(_customerControl.GetAll());
            LoadOrderTable(_orderControl.GetAll());
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
            NumTotal.Value = 0;
            CmdBill.Enabled = true;
            CmdBill.ForeColor = Color.Black;
        }

        private void EnterSaveMode()
        {
            CmdSave.BackColor = Color.MediumSeaGreen;
            CmdDelete.Enabled = false;
            CmdNew.Enabled = false;
            TxtSearch.Enabled = false;
            CmdSearch.Enabled = false;
            CmdEditCustomer.Enabled = false;
            CmdBill.Enabled = false;
            CmdBillView.Enabled = false;
            DtpDate.Focus();
        }

        private void EndSaveMode()
        {
            CmdSave.BackColor = Color.Gainsboro;
            CmdDelete.Enabled = true;
            CmdNew.Enabled = true;
            TxtSearch.Enabled = true;
            CmdSearch.Enabled = true;
            CmdEditCustomer.Enabled = true;
            CmdBill.Enabled = true;
            CmdBillView.Enabled = true;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LockFields();

            DialogResult dialogResult = MessageBox.Show(MessageBoxConstants.TextQuestionSureToDelete,
                MessageBoxConstants.CaptionQuestion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var toDelete = _orderControl.Delete(selected);
                if (toDelete != 0)
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextSuccessDelete, "Der Auftrag"),
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MessageBoxConstants.TextNotDeleted,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(MessageBoxConstants.TextNotDeleted,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            UnlockFields();
            LoadOrderTable((_orderControl.GetAll()));
        }

        private void LockFields()
        {
            DtpDate.Enabled = false;
            CbxCustomer.Enabled = false;
            TxtComment.ReadOnly = true;
        }

        private void CmdBillView_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<BillView>();
            view.Show();
        }
    }
}
