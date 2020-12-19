using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class Position
    {
        public int Id { get; set; }             // Id für Index
        public Product Product  { get; set; }   // Product
        public int Counter { get; set; }        // Anzahl der Itemes
        public double Total { get; set; }       // gesammt Summe aller Artikel
    }
}
