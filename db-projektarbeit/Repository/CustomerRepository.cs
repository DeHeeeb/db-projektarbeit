using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class CustomerRepository : RepositoryBase<Customer>
    {

        public CustomerRepository(ProjectContext context) : base(context)
        {
        }

        public new List<Customer> GetAll(ProjectContext context)
        {
            return context.Customers
                .Include(c => c.City)
                .OrderBy(c => c.CustomerNr)
                .Where(c =>
                    DateTime.Now > c.ValidFrom &&
                    DateTime.Now < c.ValidTo)
                .ToList();
        }

        public List<Customer> Search(string text, ProjectContext context)
        {
            text = text.ToLower();

            return context.Customers
                .Include(c => c.City)
                .Where(c => (
                        c.CustomerNr.ToString().ToLower().Contains(text) ||
                        c.FirstName.ToLower().Contains(text) ||
                        c.LastName.ToLower().Contains(text) ||
                        c.CompanyName.ToLower().Contains(text) ||
                        c.Street.ToLower().Contains(text) ||
                        c.HouseNumber.ToLower().Contains(text) ||
                        c.City.Zip.ToString().ToLower().Contains(text) ||
                        c.City.Name.ToLower().Contains(text)) && (
                        DateTime.Now > c.ValidFrom &&
                        DateTime.Now < c.ValidTo)
                ).OrderBy(c => c.CustomerNr)
                .ToList();
        }

        public new int Save(Customer customer, ProjectContext context)
        {
            var currentDate = DateTime.Now;

            if (customer.Id == 0)
            {
                customer.ValidFrom = currentDate;
                customer.ValidTo = DateTime.MaxValue;
                context.Customers.Add(customer);
            }
            else
            {
                var oldCustomer = context.Customers
                    .Single(c => c.Id == customer.Id);
                oldCustomer.ValidTo = currentDate;

                customer.Id = 0;
                customer.ValidFrom = currentDate;
                customer.ValidTo = DateTime.MaxValue;
                context.Customers.Add(customer);
            }

            context.SaveChanges();

            return customer.Id;
        }

        public int Delete(Customer customer, ProjectContext context)
        {
            try
            {
                customer.ValidTo = DateTime.Now;
                Update(customer, context);
                context.SaveChanges();
            }
            catch
            {
                return 0;
            }

            return customer.Id;
        }
    }
}