using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace db_projektarbeit.Data.Export
{
    public class XmlExportStrategy : ICustomerExportStrategy
    {
        public bool Export(string dataName, List<db_projektarbeit.Customer> data)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<db_projektarbeit.Customer>));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + dataName;
            try
            {
                using (var stream = File.OpenWrite(path))
                {
                    writer.Serialize(stream, data);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Export File Exeption");
            }

            return true;
        }
    }
}
