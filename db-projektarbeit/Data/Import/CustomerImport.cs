using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Data.Export;

namespace db_projektarbeit.Data.Import
{
    class CustomerImport
    {

        private readonly ICustomerImportStrategy _importStrategy;
        private readonly List<Customer> _customers;
        public CustomerImport(string path, ICustomerImportStrategy importStrategy)
        {
            _importStrategy = importStrategy;
            _customers = _importStrategy.Import(path);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
