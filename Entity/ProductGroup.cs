using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class ProductGroup
    {
        public int Id { get; set; }
        public int? ParentProductId { get; set; }
        public ProductGroup Parent { get; set; }
        public List<ProductGroup> Chrildren { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
