using System.Collections.Generic;

namespace db_projektarbeit
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public ProductGroup Parent { get; set; }
        public List<ProductGroup> Children { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
