using System;
using System.Collections.Generic;
using System.Text;

namespace db_projektarbeit
{
    public class Customer
    {
        public int Id { get; set; }         // Id für Index
        public int CustomerNr { get; set; } // Kunden Nummer
        public string Name { get; set; }    // Kunden Name
        public string Street { get; set; }  // Adresse + Hausnummer
        public int CityId { get; set; }
        public City City { get; set; }       // City
    }
}
