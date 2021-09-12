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
    public class ProductGroupIntegrationTest : IClassFixture<FormsFactory>
    {
        private readonly ProductGroupControl _productGroupControl;

        public ProductGroupIntegrationTest(FormsFactory factory)
        {
            var options = factory.Provider.GetRequiredService<DbContextOptions<ProjectContext>>();
            factory.SetupDb(options);
            _productGroupControl = factory.Provider.GetRequiredService<ProductGroupControl>();
        }

        [Fact]
        public void GivenProductGroups_WhenGetAll_ThenProductGroupsAreReturned()
        {
            var productGroups = _productGroupControl.GetAll();
            Assert.Equal(10, productGroups.Count);
        }
        
        [Fact]
        public void GivenNewProductGroup_WhenSave_ThenIdOnProductGroupIsSet()
        {
            var productGroup = new ProductGroup()
            {
                Name = "Guetzli"
            };
            var id = _productGroupControl.AddNode(productGroup);
            Assert.NotEqual(0, id);
        }

        [Fact]
        public void GivenUpdatedProductGroup_WhenSave_ThenProductGroupIsUpdated()
        {
            var productGroup = new ProductGroup()
            {
                Name = "Guetzli"
            };
            var id = _productGroupControl.AddNode(productGroup);
            var update = new ProductGroup()
            {
                Id = id,
                Name = "Backwaren"
            };
            _productGroupControl.UpdateNode(update);

            var productGroups = _productGroupControl.GetAll();
            Assert.Equal(11, productGroups.Count);
        }

        [Fact]
        public void GivenProductGroups_WhenDeleteWithId_ThenProductGroupIsDeleted()
        {
            var productGroupToDelete = _productGroupControl.GetAll().Single(c => c.Id == 1);
            _productGroupControl.DeleteNode(productGroupToDelete);
            var productGroups = _productGroupControl.GetAll();
            Assert.Equal(9, productGroups.Count);
        }

    }
}
