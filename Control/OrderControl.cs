using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class OrderControl
    {
        private readonly OrderModel OrderModel = new OrderModel();

        public List<Order> GetAll()
        {
            return OrderModel.GetAll();
        }

        public List<Order> Search(string text)
        {
            return OrderModel.Search(text);
        }

        public int Save(Order order)
        {
            return OrderModel.Save(order);
        }

        public int Delete(Order order)
        {
            return OrderModel.Delete(order);
        }

        public void Bill(int orderId)
        {
            OrderModel.Bill(orderId);
        }
    }
}
