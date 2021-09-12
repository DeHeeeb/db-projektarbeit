using db_projektarbeit.Control;
using db_projektarbeit.View.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class CityView : Form
    {
        private readonly CityControl _cityControl;
        private City selected = new City();

        public CityView(CityControl cityControl)
        {
            _cityControl = cityControl;
            InitializeComponent();
            LoadTable(_cityControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(_cityControl.GetAll());
            }
            else
            {
                LoadTable(_cityControl.Search(searchText));
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

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtName.Text) &&
                NumZip.Value != 0)
            {
                City city = new City
                {
                    Id = selected.Id,
                    Zip = (int)NumZip.Value,
                    Name = TxtName.Text
                };
                _cityControl.Save(city);

                LoadTable(_cityControl.GetAll());
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

        private void DgvCities_SelectionChanged(object sender, EventArgs e)
        {
            var rows = DgvCities.SelectedRows;
            DataGridViewRow row;
            if (rows.Count == 0 && DgvCities.SelectedCells.Count == 1)
            {
                row = DgvCities.SelectedCells[0].OwningRow;
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

            selected = (City)row.DataBoundItem;
            NumZip.Value = selected.Zip;
            TxtName.Text = selected.Name;
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            UnlockFields();
            EnterSaveMode();
        }

        private void LoadTable(List<City> cities)
        {
            DgvCities.DataSource = cities;

            DgvCities.Columns[0].Visible = false;
            DgvCities.Columns[3].Visible = false;
            DgvCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCities.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCities.Columns[1].HeaderText = "PLZ";
            DgvCities.Columns[2].HeaderText = "Name";
        }

        private void ClearFields()
        {
            selected = new City();
            NumZip.Value = NumZip.Minimum;
            TxtName.Clear();
        }

        private void UnlockFields()
        {
            NumZip.ReadOnly = false;
            TxtName.ReadOnly = false;
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
                var toDelete = _cityControl.Delete(selected);
                if (toDelete != 0)
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextSuccessDelete, "Die Stadt"),
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format(MessageBoxConstants.TextErrorDeleteBecauseLink, "Kunden"),
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
            LoadTable(_cityControl.GetAll());
        }

        private void LockFields()
        {
            NumZip.ReadOnly = true;
            TxtName.ReadOnly = true;
        }

        private void EnterSaveMode()
        {
            CmdSave.BackColor = Color.MediumSeaGreen;
            CmdDelete.Enabled = false;
            CmdNew.Enabled = false;
            TxtSearch.Enabled = false;
            CmdSearch.Enabled = false;
            NumZip.Focus();
        }

        private void EndSaveMode()
        {
            CmdSave.BackColor = Color.Gainsboro;
            CmdDelete.Enabled = true;
            CmdNew.Enabled = true;
            TxtSearch.Enabled = true;
            CmdSearch.Enabled = true;
        }
    }
}
