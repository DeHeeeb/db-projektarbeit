using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace db_projektarbeit.Data.Import
{
    class JsonImportStrategy : ICustomerImportStrategy
    {
        public List<Customer> Import(string path)
        {
            var customers = new List<db_projektarbeit.Customer>();

            try
            {
                using(StreamReader file = File.OpenText(path))
                {
                    customers = JsonConvert.DeserializeObject<List<Customer>>(file.ReadToEnd());
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
