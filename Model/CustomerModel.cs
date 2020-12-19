using System;
using System.Collections.Generic;
using System.Text;

namespace db_projektarbeit.Model
{
    class CustomerModel
    {
        public Customer GetById(int id)
        {
            using (var context = new ProjectContext())
            {
                return context.Customers.Find(id);
            }
        }
    }
}
