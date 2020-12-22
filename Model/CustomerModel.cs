﻿using Microsoft.EntityFrameworkCore;
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

        public List<Customer> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
                return context.Customers
                    .Include(c => c.City)
                    .Where(c => 
                        c.CustomerNr.ToString().ToLower().Contains(text) ||
                        c.Name.ToLower().Contains(text) ||
                        c.Street.ToLower().Contains(text) ||
                        c.City.Zip.ToString().ToLower().Contains(text) ||
                        c.City.Name.ToLower().Contains(text)
                    ).ToList();
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
                    context.Customers.Attach(customer);
                    context.Entry(customer).State = EntityState.Modified;
                }
                context.SaveChanges();

                return customer.Id;
            }
        }
    }
}
