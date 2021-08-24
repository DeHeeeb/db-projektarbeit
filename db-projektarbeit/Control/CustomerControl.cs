using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class CustomerControl
    {
        private readonly CustomerRepository CustomerRepository = new CustomerRepository(new ProjectContext());

        public List<Customer> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return CustomerRepository.GetAll(context);
        }

        public List<Customer> Search(string text)
        {
            using ProjectContext context = new ProjectContext();
            return CustomerRepository.Search(text, context);
        }

        public int Save(Customer customer)
        {
            using ProjectContext context = new ProjectContext();
            return CustomerRepository.Save(customer, context);
        }

        public int Delete(Customer customer)
        {
            using ProjectContext context = new ProjectContext();
            return CustomerRepository.Delete(customer, context);
        }
    }
}