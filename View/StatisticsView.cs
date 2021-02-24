using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;

namespace db_projektarbeit.View
{
    public partial class StatisticsView : Form
    {
        StatisticsControl statisticsControl = new StatisticsControl();

        public StatisticsView()
        {
            InitializeComponent();
        }

        private void StatisticsView_Load(object sender, EventArgs e)
        {
            DgvStatisticsSelfe.DataSource = statisticsControl.GetAllSelfe();
            DgvStatisticsSelfe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            for (int i = 1; i < DgvStatisticsSelfe.Columns.Count; i++)
            {
                DgvStatisticsSelfe.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DgvStatisticsSelfe.RowsDefaultCellStyle.BackColor = Color.Bisque;
            DgvStatisticsSelfe.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            DgvStatisticsSelfe.ScrollBars = ScrollBars.None;

            DgvStatisticsCustomer.DataSource = statisticsControl.GetAllCustomer();
            DgvStatisticsCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            for (int i = 1; i < DgvStatisticsCustomer.Columns.Count; i++)
            {
                DgvStatisticsCustomer.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DgvStatisticsCustomer.RowsDefaultCellStyle.BackColor = Color.Bisque;
            DgvStatisticsCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
    }
}
