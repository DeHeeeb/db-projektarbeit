using db_projektarbeit.Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace db_projektarbeit.View
{
    public partial class StatisticsView : Form
    {
        private readonly StatisticsControl _statisticsControl;

        public StatisticsView(StatisticsControl statisticsControl)
        {
            this._statisticsControl = statisticsControl;
            InitializeComponent();
        }

        private void StatisticsView_Load(object sender, EventArgs e)
        {
            DgvStatisticsSelf.DataSource = _statisticsControl.GetAllSelf();
            DgvStatisticsSelf.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            for (int i = 1; i < DgvStatisticsSelf.Columns.Count; i++)
            {
                DgvStatisticsSelf.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DgvStatisticsSelf.RowsDefaultCellStyle.BackColor = Color.Bisque;
            DgvStatisticsSelf.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            DgvStatisticsSelf.ScrollBars = ScrollBars.None;

            DgvStatisticsCustomer.DataSource = _statisticsControl.GetAllCustomer();
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
