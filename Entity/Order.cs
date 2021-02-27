using System;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit
{
    public class Order
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public int OrderNr { get; set; }
        public string? Comment { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Position> Positions { get; set; }
        public decimal Total => GetTotal();
        public bool Billed { get; set; }

        public decimal GetTotal()
        {
            if (Positions?.Count > 0)
            {
                return Positions.Sum(p => p.Total);
            }
            else
            {
                return 0;
            }
        }
    }
}
