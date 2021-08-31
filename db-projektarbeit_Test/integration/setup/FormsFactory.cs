using System;
using db_projektarbeit.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit_Test.integration.setup
{
    public class FormsFactory
    {
        internal IServiceProvider Provider;

        public FormsFactory()
        {
            var services = new ServiceCollection();

            db_projektarbeit.Program.ConfigureServices(services);

            services.AddSingleton(
                new DbContextOptionsBuilder<ProjectContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options);

            Provider = services
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
        }

        public void SetupDb(DbContextOptions<ProjectContext> options)
        {
            using var context = new ProjectContext(options);

            context.Customers.RemoveRange(context.Customers);
            context.Cities.RemoveRange(context.Cities);
            SeedData.Populate(context);

            context.SaveChanges();
        }
    }
}
