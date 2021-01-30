using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace db_projektarbeit.Model
{
    class OrderModel
    {
        public List<Order> GetAll()
        {
            using (var context = new ProjectContext())
            {
                return context.Orders
                    .Include(o => o.Positions)
                    .ThenInclude(p => p.Product)
                    .Include(o => o.Customer)
                    .OrderByDescending(o => o.Date)
                    .ToList();
            }
        }

        public List<Order> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
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
        }

        public int Save(Order order)
        {
            using (var context = new ProjectContext())
            {
                if (order.Id == 0)
                {
                    context.Orders.Add(order);
                }
                else
                {
                    context.Orders.Update(order);
                }

                context.SaveChanges();

                return order.Id;
            }
        }

        public int Delete(Order order)
        {
            try
            {
                using (var context = new ProjectContext())
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return order.Id;
        }
    }
}
