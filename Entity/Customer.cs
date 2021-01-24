using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    public class Customer
    {
        public int Id { get; set; }                 // Id für Index
        public int CustomerNr { get; set; }         // Kunden Nummer
        public string FirstName { get; set; }       // Vorname Kunde
        public string LastName { get; set; }        // Nachname Kunde
        public string? CompanyName { get; set; }     // Firmenname
        [NotMapped]
        public string FullName => ToString();
        public string Street { get; set; }          // Adresse
        public  string? HouseNumber { get; set; }    // Hausnummer
        public int CityId { get; set; }             // 
        public City City { get; set; }              // City

        public override string ToString()
        {
            if (CompanyName != null)
            {
                return CompanyName + " / " + FirstName + " " + LastName;
            }
            else
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
