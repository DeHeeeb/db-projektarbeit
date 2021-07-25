using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using db_projektarbeit.Data;

namespace db_projektarbeit.Data.Import
{
    class XmlImportStrategy : ICustomerImportStrategy
    {
        public List<db_projektarbeit.Customer> Import(string path)
        {
            var customers = new List<db_projektarbeit.Customer>();
            var serializer = new XmlSerializer(typeof(List<db_projektarbeit.Customer>));

            try
            {
                using (var stream = File.OpenRead(path))
                {
                    var xmlCustomers = (List<db_projektarbeit.Customer>)(serializer.Deserialize(stream));
                    customers = xmlCustomers;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Import File Exeption", e);
            }

            return customers;
        }
    }
}
