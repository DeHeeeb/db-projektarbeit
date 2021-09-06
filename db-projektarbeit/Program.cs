using db_projektarbeit.View;
using System;
using System.Windows.Forms;
using db_projektarbeit.Control;
using db_projektarbeit.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var home = serviceProvider.GetRequiredService<Home>();
            home.SetProvider(serviceProvider);
            Application.Run(home);
        }

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<BillView>();
            services.AddTransient<CityView>();
            services.AddTransient<CustomerView>();
            services.AddTransient<ExportView>();
            services.AddTransient<Home>();
            services.AddTransient<ImportView>();
            services.AddTransient<OrderView>();
            services.AddTransient<PositionView>();
            services.AddTransient<ProductGroupView>();
            services.AddTransient<ProductView>();
            services.AddTransient<StatisticsView>();

            services.AddTransient<BillControl>();
            services.AddTransient<CityControl>();
            services.AddTransient<CustomerControl>();
            services.AddTransient<HomeControl>();
            services.AddTransient<OrderControl>();
            services.AddTransient<PositionControl>();
            services.AddTransient<ProductControl>();
            services.AddTransient<ProductGroupControl>();
            services.AddTransient<StatisticsControl>();

            services.AddTransient<BillRepository>();
            services.AddTransient<CityRepository>();
            services.AddTransient<CustomerRepository>();
            services.AddTransient<HomeRepository>();
            services.AddTransient<OrderRepository>();
            services.AddTransient<PositionRepository>();
            services.AddTransient<ProductGroupRepository>();
            services.AddTransient<ProductRepository>();
            services.AddTransient<StatisticsRepository>();

            services.AddSingleton(new DbContextOptionsBuilder<ProjectContext>()
                .UseSqlServer("Data Source=.; Database=Accounting; Trusted_Connection=True")
                .Options);
        }

    }
}
