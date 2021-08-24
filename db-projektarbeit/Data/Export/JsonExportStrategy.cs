using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace db_projektarbeit.Data.Export
{
    class JsonExportStrategy : ICustomerExportStrategy
    {
        public bool Export(string path, List<db_projektarbeit.Customer> data)
        {
            var jsonString = JsonSerializer.Serialize(data);

            try
            {
                using (StreamWriter file = File.CreateText(path))
                {
                    file.Write(JsonSerializer.Serialize(data));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Export File Exeption", e);
            }

            return true;
        }
    }
}
