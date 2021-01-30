using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    public class Position
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Total => GetTotal();

        public decimal GetTotal()
        {
            return Count * Product.Price;
        }
    }
}
