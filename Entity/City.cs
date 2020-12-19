using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    public class City
    {
        public int Id { get; set; }         // Id für Index
        public int Zip { get; set; }        // Postleitzahl
        public string Name { get; set; }    // Ortsname
    }
}
