using System.Collections.Generic;

namespace db_projektarbeit.Data.Import
{
    interface ICustomerImportStrategy
    {
        List<db_projektarbeit.Customer> Import(string path);
    }
}
