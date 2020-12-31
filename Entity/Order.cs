using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class Order
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
