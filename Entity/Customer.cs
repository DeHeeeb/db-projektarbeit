using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_projektarbeit
{
    public class Customer
    {
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerNr { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string FullName => ToString();
        public string Street { get; set; }
        public  string? HouseNumber { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

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
