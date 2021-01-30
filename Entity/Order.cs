using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace db_projektarbeit
{
    public class Order
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Position> Positions { get; set; }
        public decimal Total => GetTotal();

        public decimal GetTotal()
        {
            return Positions.Sum(p => p.Total);
        }
    }
}
