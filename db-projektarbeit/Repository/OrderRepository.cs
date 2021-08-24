using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(ProjectContext context) : base(context)
        {
        }

        public new List<Order> GetAll(ProjectContext context)
        {
            var orders = context.Orders
                .Include(o => o.Positions)
                .ThenInclude(p => p.Product)
                .Include(o => o.Customer)
                .OrderByDescending(o => o.Date)
                .ToList();

            foreach (var order in orders)
            {
                order.Customer = context.Customers.SingleOrDefault(c =>
                    c.CustomerNr == order.Customer.CustomerNr &&
                    DateTime.Now > c.ValidFrom &&
                    DateTime.Now < c.ValidTo);
                order.Date = order.Date.Date;
            }

            return orders;
        }

        public List<Order> Search(string text, ProjectContext context)
        {
            text = text.ToLower();

            return context.Orders
                .Include(o => o.Positions)
                .ThenInclude(p => p.Product)
                .Include(o => o.Customer)
                .Where(o =>
                    o.Date.ToString().Contains(text) ||
                    o.Comment.ToLower().Contains(text) ||
                    o.Customer.CompanyName.ToLower().Contains(text) ||
                    o.Customer.FirstName.ToLower().Contains(text) ||
                    o.Customer.LastName.ToLower().Contains(text) ||
                    o.Customer.CustomerNr.ToString().Contains(text)
                ).OrderByDescending(o => o.Date)
                .ToList();
        }

        public new int Save(Order order, ProjectContext context)
        {
            if (order.Id == 0)
            {
                context.Orders.Add(order);
            }
            else
            {
                var customer = context.Customers.SingleOrDefault(c => c.Id == order.CustomerId);
                order.Customer = context.Customers.SingleOrDefault(c =>
                    c.CustomerNr == customer.CustomerNr &&
                    DateTime.Now > c.ValidFrom &&
                    DateTime.Now < c.ValidTo);
                context.Orders.Update(order);
            }

            context.SaveChanges();

            return order.Id;
        }

        public void Bill(int orderId, ProjectContext context)
        {
            var order = context.Orders.SingleOrDefault(o => o.Id == orderId);
            order.Billed = true;
            context.Orders.Update(order);

            context.SaveChanges();
        }


    }
}