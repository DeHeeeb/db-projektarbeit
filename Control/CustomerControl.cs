using db_projektarbeit.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace db_projektarbeit.Control
{
    class CustomerControl
    {
        private CustomerModel CustomerModel = new CustomerModel();

        public Customer GetById(int id)
        {
            return CustomerModel.GetById(id);
        }
    }
}
