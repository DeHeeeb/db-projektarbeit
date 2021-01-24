﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;

namespace db_projektarbeit.View
{
    public partial class CityView : Form
    {
        CityControl CityControl = new CityControl();
        City selected = new City();

        public CityView()
        {
            InitializeComponent();
            LoadTable(CityControl.GetAll());
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var searchText = TxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTable(CityControl.GetAll());
            }
            else
            {
                LoadTable(CityControl.Search(searchText));
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
                CityControl.Save(city);

                LoadTable(CityControl.GetAll());
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
        }

        private void LoadTable(List<City> cities)
        {
            DgvCities.DataSource = cities;

            DgvCities.Columns[0].Visible = false;
            DgvCities.Columns[3].Visible = false;
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
    }
}