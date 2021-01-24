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
                return context.Orders.Include(p => p.Positions)
                                     .Include(c => c.Customer)
                                     .ToList();
            }
        }
    }
}
