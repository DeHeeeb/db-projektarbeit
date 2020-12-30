using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Model;

namespace db_projektarbeit.Control
{
    class ProductGroupControl
    {
        private ProductGroupModel ProductGroupModel = new ProductGroupModel();

        public List<Product> GetAllProductGroup()
        {
            return ProductGroupModel.GetAllProductGroup();
        }
    }
}
