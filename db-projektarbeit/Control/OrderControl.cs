using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class OrderControl
    {
        private readonly OrderRepository OrderRepository = new OrderRepository(new ProjectContext());

        public List<Order> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return OrderRepository.GetAll(context);
        }

        public List<Order> Search(string text)
        {
            using ProjectContext context = new ProjectContext();
            return OrderRepository.Search(text, context);
        }

        public int Save(Order order)
        {
            using ProjectContext context = new ProjectContext();
            return OrderRepository.Save(order, context);
        }

        public int Delete(Order order)
        {
            using ProjectContext context = new ProjectContext();
            var deleted = OrderRepository.Delete(order.Id, context);
            return deleted?.Id ?? 0;
        }

        public void Bill(int orderId)
        {
            using ProjectContext context = new ProjectContext();
            OrderRepository.Bill(orderId, context);
        }
    }
}