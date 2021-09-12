using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Control;

namespace db_projektarbeit.Data.Export
{
    class CustomerExport
    {
        private readonly ICustomerExportStrategy _exportStrategy;
        public CustomerExport(string dataName,ICustomerExportStrategy exportStrategy, CustomerControl customerControl)
        {
            _exportStrategy = exportStrategy;
            
            var customerAll = customerControl.GetAll();

            _exportStrategy.Export(dataName, customerAll);
        }
    }
}
