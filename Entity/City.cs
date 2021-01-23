
using System.ComponentModel.DataAnnotations.Schema;

namespace db_projektarbeit
{
    public class City
    {
        public int Id { get; set; }         // Id für Index
        public int Zip { get; set; }        // Postleitzahl
        public string Name { get; set; }    // Ortsname
        [NotMapped]
        public string DisplayName => ToString();

        public override string ToString()
        {
            return Zip + " " + Name;
        }
    }
}
