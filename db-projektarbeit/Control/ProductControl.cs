using System;
using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class ProductControl
    {
        private readonly ProductRepository ProductRepository = new ProductRepository(new ProjectContext());

        public List<Product> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return ProductRepository.GetAll(context);
        }

        public List<Product> Search(string text)
        {
            using ProjectContext context = new ProjectContext();
            return ProductRepository.Search(text, context);
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            using ProjectContext context = new ProjectContext();
            return ProductRepository.SearchUsedProductGroup(productGroup, context);
        }

        public int Save(Product product)
        {
            using ProjectContext context = new ProjectContext();
            if (product.Id == 0)
            {
                product.CreationDate = DateTime.Now.Date;
                ProductRepository.Save(product, context);
            }
            else
            {
                ProductRepository.Update(product, context);
            }

            return product.Id;
        }

        public int Delete(Product product)
        {
            using ProjectContext context = new ProjectContext();
            var deleted = ProductRepository.Delete(product.Id, context);

            return deleted?.Id ?? 0;
        }
    }
}