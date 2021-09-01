using System;
using System.Linq;
using db_projektarbeit;
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
        public void GivenCustomers_WhenGetAll_ThenCustomersAreReturned()
        {
            var customers = _customerControl.GetAll();
            Assert.Equal(3, customers.Count);
        }

        [Fact]
        public void GivenCustomers_WhenSearch_ThenCorrectCustomersAreReturned()
        {
            var customers = _customerControl.Search("er");
            Assert.Equal(2, customers.Count);
        }
        
        [Fact]
        public void GivenNewCustomer_WhenSave_ThenIdOnCustomerIsSet()
        {
            var customer = new Customer()
            {
                FirstName = "Thomas",
                LastName = "Muster"
            };
            var id = _customerControl.Save(customer);
            Assert.NotEqual(0, id);
        }

        [Fact]
        public void GivenUpdatedCustomer_WhenSave_ThenCustomerIsUpdated()
        {
            var customer = new Customer()
            {
                FirstName = "Thomas",
                LastName = "Muster",
                ValidFrom = new DateTime(1, 1, 1),
                ValidTo = new DateTime(3000, 1, 1),
                CityId = 1
            };
            var id = _customerControl.Save(customer);
            var update = new Customer()
            {
                Id = id,
                FirstName = "Hans",
                LastName = "Muster",
                ValidFrom = new DateTime(1, 1, 1),
                ValidTo = new DateTime(3000, 1, 1),
                CityId = 1
            };
            _customerControl.Save(update);

            var customers = _customerControl.GetAll();
            Assert.Equal(4, customers.Count);
        }

        [Fact]
        public void GivenCustomers_WhenDeleteWithId_ThenCustomerIsDeleted()
        {
            var customerToDelete = _customerControl.GetAll().Single(c => c.Id == 1);
            _customerControl.Delete(customerToDelete);
            var customers = _customerControl.GetAll();
            Assert.Equal(2, customers.Count);
        }

    }
}
