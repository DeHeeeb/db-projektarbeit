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
                return context.Customers
                    .Include(c => c.City)
                    .OrderBy(c => c.CustomerNr)
                    .ToList();
            }
        }

        public List<Customer> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
                return context.Customers
                    .Include(c => c.City)
                    .Where(c => 
                        c.CustomerNr.ToString().ToLower().Contains(text) ||
                        c.FirstName.ToLower().Contains(text) ||
                        c.LastName.ToLower().Contains(text) ||
                        c.CompanyName.ToLower().Contains(text) ||
                        c.Street.ToLower().Contains(text) ||
                        c.HouseNumber.ToLower().Contains(text) ||
                        c.City.Zip.ToString().ToLower().Contains(text) ||
                        c.City.Name.ToLower().Contains(text)
                    ).OrderBy(c => c.CustomerNr)
                    .ToList();
            }
        }

        public int Save(Customer customer)
        {
            using (var context = new ProjectContext())
            {
                if (customer.Id == 0)
                {
                    context.Customers.Add(customer);
                } else
                {
                    context.Customers.Update(customer);
                }
                context.SaveChanges();

                return customer.Id;
            }
        }
    }
}
