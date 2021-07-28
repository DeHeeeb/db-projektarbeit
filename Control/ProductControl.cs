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
            return ProductRepository.GetAll();
        }

        public List<Product> Search(string text)
        {
            return ProductRepository.Search(text);
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return ProductRepository.SearchUsedProductGroup(productGroup);
        }

        public int Save(Product product)
        {
            if (product.Id == 0)
            {
                product.CreationDate = DateTime.Now.Date;
                ProductRepository.Save(product);
            }
            else
            {
                ProductRepository.Update(product);
            }

            return product.Id;
        }

        public int Delete(Product product)
        {
            var deleted = ProductRepository.Delete(product.Id);

            return deleted?.Id ?? 0;
        }
    }
}