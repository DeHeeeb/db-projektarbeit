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

        /*public List<Customer> Search(string text)
        {
            return ProductModel.Search(text);
        }*/

        public int Save(Product product)
        {
            return ProductModel.Save(product);
        }
    }
}
