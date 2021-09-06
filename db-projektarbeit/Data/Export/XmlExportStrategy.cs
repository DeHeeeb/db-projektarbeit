using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace db_projektarbeit.Data.Export
{
    public class XmlExportStrategy : ICustomerExportStrategy
    {
        public bool Export(string path, List<Customer> data)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<db_projektarbeit.Customer>));

            try
            {
                using (var stream = File.OpenWrite(path))
                {
                    writer.Serialize(stream, data);
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
