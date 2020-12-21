using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class CustomerControl
    {
        private CustomerModel CustomerModel = new CustomerModel();

        public List<Customer> GetAll()
        {
            return CustomerModel.GetAll();
        }

        public Customer GetById(int id)
        {
            return CustomerModel.GetById(id);
        }
    }
}
