using db_projektarbeit.Control;
using db_projektarbeit.Repository;
using db_projektarbeit_Test.integration.setup;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit_Test.integration
{
    public class CustomerIntegrationTest : IClassFixture<FormsFactory>
    {
        private readonly CustomerControl _customerControl;

        public CustomerIntegrationTest(FormsFactory factory)
        {
            var options = factory.Provider.GetRequiredService<DbContextOptions<ProjectContext>>();
            factory.SetupDb(options);
            _customerControl = factory.Provider.GetRequiredService<CustomerControl>();
        }

        [Fact]
        public void GivenCustomer_WhenGetAll_CustomerIsReturned()
        {
            var customers = _customerControl.GetAll();
            Assert.Single(customers);
        }
    }
}
