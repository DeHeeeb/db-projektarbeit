using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace db_projektarbeit
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BillNr { get; set; }
        public int CustomerNr => Customer.CustomerNr;
        public Customer Customer { get; set; }
        public string Street => Customer.Street;
        public string HouseNumber => Customer.HouseNumber;
        public string City => Customer.City.DisplayName;
        public string Country => "CH";
        public int CustomerId { get; set; }
        public decimal Brutto => GetBrutto();
        public decimal Netto { get; set; }

        public decimal GetBrutto()
        {
            return Math.Round(Netto * 0.923M, 2);
        }

    }
}
