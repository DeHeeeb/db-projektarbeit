using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductNr { get; set; }
        public int GroupId { get; set; }
        public ProductGroup Group { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        [NotMapped]
        public string DisplayName => ToString();

        public override string ToString()
        {
            return  ProductNr +", "+ Description;
        }
    }
}
