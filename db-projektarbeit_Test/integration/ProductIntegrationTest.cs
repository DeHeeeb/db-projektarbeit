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
    public class ProductIntegrationTest : IClassFixture<FormsFactory>
    {
        private readonly ProductControl _productControl;

        public ProductIntegrationTest(FormsFactory factory)
        {
            var options = factory.Provider.GetRequiredService<DbContextOptions<ProjectContext>>();
            factory.SetupDb(options);
            _productControl = factory.Provider.GetRequiredService<ProductControl>();
        }

        [Fact]
        public void GivenProducts_WhenGetAll_ThenProductsAreReturned()
        {
            var products = _productControl.GetAll();
            Assert.Equal(4, products.Count);
        }
        
        [Fact]
        public void GivenNewProduct_WhenSave_ThenIdOnProductIsSet()
        {
            var product = new Product
            {
                GroupId = 2,
                Description = "Super Stuhl",
                Price = 360.50M,
                CreationDate = new DateTime(2020, 07, 02)
            };
            var id = _productControl.Save(product);
            Assert.NotEqual(0, id);
        }

        [Fact]
        public void GivenUpdatedProduct_WhenSave_ThenProductIsUpdated()
        {
            var product = new Product
            {
                GroupId = 2,
                Description = "Super Stuhl",
                Price = 360.50M,
                CreationDate = new DateTime(2020, 07, 02)
            };
            var id = _productControl.Save(product);
            var update = new Product
            {
                Id = id,
                GroupId = 2,
                Description = "Mega Stuhl",
                Price = 800M,
                CreationDate = new DateTime(2020, 07, 02)
            };
            _productControl.Save(update);

            var productGroups = _productControl.GetAll();
            Assert.Equal(5, productGroups.Count);
        }

        [Fact]
        public void GivenProducts_WhenDeleteWithId_ThenProductIsDeleted()
        {
            var productToDelete = _productControl.GetAll().Single(c => c.Id == 1);
            _productControl.Delete(productToDelete);
            var productGroups = _productControl.GetAll();
            Assert.Equal(3, productGroups.Count);
        }

    }
}
