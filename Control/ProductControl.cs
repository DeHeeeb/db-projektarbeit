using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class ProductControl
    {
        private ProductModel ProductModel = new ProductModel();

        public List<Product> GetAll()
        {
            return ProductModel.GetAll();
        }

        public List<Product> Search(string text)
        {
            return ProductModel.Search(text);
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return ProductModel.SearchUsedProductGroup(productGroup);
        }

        public int Save(Product product)
        {
            return ProductModel.Save(product);
        }

        public int Delete(Product product)
        {
            var deletedId = ProductModel.Delete(product);
            if (deletedId != 0)
            {
                return deletedId;
            }
            else
            {
                return 0;
            }
        }
    }
}
