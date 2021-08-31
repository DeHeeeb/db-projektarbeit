using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class CustomerControl
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerControl(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public List<Customer> Search(string text)
        {
            return _customerRepository.Search(text);
        }

        public int Save(Customer customer)
        {
            return _customerRepository.Save(customer);
        }

        public int Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }
    }
}