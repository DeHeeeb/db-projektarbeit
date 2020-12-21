using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_projektarbeit.Model
{
    class CustomerModel
    {
        public List<Customer> GetAll()
        {
            using (var context = new ProjectContext())
            {
                return context.Customers.Include(c => c.City).ToList();
            }
        }

        public Customer GetById(int id)
        {
            using (var context = new ProjectContext())
            {
                return context.Customers.Find(id);
            }
        }
    }
}
