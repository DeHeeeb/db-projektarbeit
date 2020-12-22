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

        public List<Customer> Search(string text)
        {
            return CustomerModel.Search(text);
        }

        public int Save(Customer customer)
        {
            return CustomerModel.Save(customer);
        }
    }
}
