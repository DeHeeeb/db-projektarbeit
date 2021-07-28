﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Repository
{
    class BillRepository : RepositoryBase<Bill>
    {

        private readonly ProjectContext _context;
        public BillRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public List<Bill> GetAll()
        {
            var bills = _context.Bills
                .Include(b => b.Customer)
                .ThenInclude(c => c.City)
                .OrderByDescending(b => b.Date)
                .ToList();

            foreach (var bill in bills)
            {
                bill.Customer = _context.Customers.Where(c =>
                        c.CustomerNr == bill.Customer.CustomerNr &&
                        bill.Date >= c.ValidFrom &&
                        bill.Date <= c.ValidTo)
                    .Include(c => c.City)
                    .SingleOrDefault();
            }

            return bills;
        }

        public List<Bill> Search(string text)
        {
            text = text.ToLower();
            return GetAll().Where(b =>
                b.Customer.CustomerNr.ToString().Contains(text) ||
                b.Customer.FullName.ToLower().Contains(text) ||
                b.Customer.Street.ToLower().Contains(text) ||
                b.Customer.City.DisplayName.ToLower().Contains(text)
            ).ToList();
        }
    }
}