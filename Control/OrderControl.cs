using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class OrderControl
    {
        private readonly OrderRepository OrderRepository = new OrderRepository();

        public List<Order> GetAll()
        {
            return OrderRepository.GetAll();
        }

        public List<Order> Search(string text)
        {
            return OrderRepository.Search(text);
        }

        public int Save(Order order)
        {
            return OrderRepository.Save(order);
        }

        public int Delete(Order order)
        {
            var deleted = OrderRepository.Delete(order.Id);
            return deleted?.Id ?? 0;
        }

        public void Bill(int orderId)
        {
            OrderRepository.Bill(orderId);
        }
    }
}