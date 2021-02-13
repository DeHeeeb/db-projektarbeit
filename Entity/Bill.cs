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
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal Brutto => GetBrutto();
        public decimal Netto { get; set; }

        public decimal GetBrutto()
        {
            return Netto * 0.923M;
        }

    }
}
