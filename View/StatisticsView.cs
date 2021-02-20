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
            DgvStatistics.DataSource = statisticsControl.GetAll();
            DgvStatistics.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            for (int i = 1; i < DgvStatistics.Columns.Count; i++)
            {
                DgvStatistics.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DgvStatistics.RowsDefaultCellStyle.BackColor = Color.Bisque;
            DgvStatistics.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
    }
}
