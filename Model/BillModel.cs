using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using db_projektarbeit.Control;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Model
{
    class BillModel
    {

        public List<Bill> GetAll()
        {
            using (var context = new ProjectContext())
            {
                var bills = context.Bills
                    .Include(b => b.Customer)
                    .ThenInclude(c => c.City)
                    .OrderByDescending(b => b.Date)
                    .ToList();

                foreach (var bill in bills)
                {
                    bill.Customer = context.Customers.Where(c =>
                        c.CustomerNr == bill.Customer.CustomerNr &&
                        bill.Date >= c.ValidFrom &&
                        bill.Date <= c.ValidTo)
                        .Include(c => c.City)
                        .SingleOrDefault();
                }

                return bills;
            }
        }

        public List<Bill> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
                var bills = GetAll();
                return bills.Where(b =>
                    b.Customer.CustomerNr.ToString().Contains(text) ||
                    b.Customer.FullName.ToLower().Contains(text) ||
                    b.Customer.Street.ToLower().Contains(text) ||
                    b.Customer.City.DisplayName.ToLower().Contains(text)
                ).ToList();
            }
        }

        public int Save(Bill bill)
        {
            using (var context = new ProjectContext())
            {
                context.Bills.Add(bill);
                context.SaveChanges();

                return bill.Id;
            }
        }
    }
}