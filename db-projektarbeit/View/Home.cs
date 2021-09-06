using db_projektarbeit.Control;
using db_projektarbeit.View.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;
using db_projektarbeit.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit.View
{
    public partial class Home : Form
    {
        private IServiceProvider _provider;
        private readonly HomeControl _homeControl;
        private readonly DbContextOptions<ProjectContext> Options;

        public Home(HomeControl homeControl, DbContextOptions<ProjectContext> options)
        {
            _homeControl = homeControl;
            Options = options;
            InitializeComponent();
        }

        public void SetProvider(IServiceProvider provider)
        {
            this._provider = provider;
        }

        private void CmdCustomer_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<CustomerView>();
            view.SetProvider(_provider);
            view.Show();
        }

        private void CmdCity_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<CityView>();
            view.Show();
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<ProductView>();
            view.SetProvider(_provider);
            view.Show();
        }

        private void CmdProductGroup_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<ProductGroupView>();
            view.Show();
        }

        private void CmdOrder_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<OrderView>();
            view.SetProvider(_provider);
            view.Show();
        }

        private void CmdBill_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<BillView>();
            view.Show();
        }
        private void CmdStatistics_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<StatisticsView>();
            view.Show();
        }
        private void CmdExportCustomer_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<ExportView>();
            view.SetProvider(_provider);
            view.Show();
        }

        private void CmdImportCustomer_Click(object sender, EventArgs e)
        {
            var view = _provider.GetRequiredService<ImportView>();
            view.Show();
        }

        private void TimerSQLCheck_Tick(object sender, EventArgs e)
        {
            using var context = new ProjectContext(Options);
            if (!context.Database.CanConnect())
            {
                try
                {
                    context.Database.Migrate();

                    MessageBox.Show(MessageBoxConstants.TextDBMigrated,
                        MessageBoxConstants.CaptionSuccess,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            var sqlCheck = _homeControl.GetStatusSQL();
            if (sqlCheck)
            {
                LblSQLCheck.Text = "SQL Server verbunden";
                CmdBill.Enabled = true;
                CmdCity.Enabled = true;
                CmdCustomer.Enabled = true;
                CmdOrder.Enabled = true;
                CmdOrder.BackColor = Color.MediumSeaGreen;
                CmdProduct.Enabled = true;
                CmdProductGroup.Enabled = true;
                CmdStatistics.Enabled = true;
            }
            else
            {
                LblSQLCheck.Text = "SQL Server nicht verbunden";
            }
        }
    }
}
