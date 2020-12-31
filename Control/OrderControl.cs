using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Model;

namespace db_projektarbeit.Control
{
    class OrderControl
    {
        private OrderModel OrderModel = new OrderModel();
        public List<Order> GetAll()
        {
            return OrderModel.GetAll();
        }
    }
}
