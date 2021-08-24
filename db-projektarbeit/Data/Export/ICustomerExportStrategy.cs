using System;
using System.Collections.Generic;
using System.Text;

namespace db_projektarbeit.Data.Export
{
    interface ICustomerExportStrategy
    {
        bool Export(string dataName, List<db_projektarbeit.Customer> customers);
    }
}
