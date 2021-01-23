using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Model;
using System.Windows.Forms;

namespace db_projektarbeit.Control
{
    class ProductGroupControl
    {
        private ProductGroupModel ProductGroupModel = new ProductGroupModel();

        public List<ProductGroup> GetAll()
        {
            return ProductGroupModel.GetAll();
        }
    }
}
