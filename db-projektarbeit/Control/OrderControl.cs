using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class OrderControl
    {
        private readonly OrderRepository _orderRepository;

        public OrderControl(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public List<Order> Search(string text)
        {
            return _orderRepository.Search(text);
        }

        public int Save(Order order)
        {
            return _orderRepository.Save(order);
        }

        public int Delete(Order order)
        {
            var deleted = _orderRepository.Delete(order.Id);
            return deleted?.Id ?? 0;
        }

        public void Bill(int orderId)
        {
            _orderRepository.Bill(orderId);
        }
    }
}