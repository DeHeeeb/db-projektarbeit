using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class CustomerControl
    {
        private readonly CustomerRepository CustomerRepository = new CustomerRepository(new ProjectContext());

        public List<Customer> GetAll()
        {
            return CustomerRepository.GetAll();
        }

        public List<Customer> Search(string text)
        {
            return CustomerRepository.Search(text);
        }

        public int Save(Customer customer)
        {
            return CustomerRepository.Save(customer);
        }

        public int Delete(Customer customer)
        {
            return CustomerRepository.Delete(customer);
        }
    }
}