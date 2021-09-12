using System;
using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class ProductControl
    {
        private readonly ProductRepository _productRepository;

        public ProductControl(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public List<Product> Search(string text)
        {
            return _productRepository.Search(text);
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return _productRepository.SearchUsedProductGroup(productGroup);
        }

        public int Save(Product product)
        {
            if (product.Id == 0)
            {
                product.CreationDate = DateTime.Now.Date;
                _productRepository.Save(product);
            }
            else
            {
                _productRepository.Update(product);
            }

            return product.Id;
        }

        public int Delete(Product product)
        {
            var deleted = _productRepository.Delete(product.Id);

            return deleted?.Id ?? 0;
        }
    }
}