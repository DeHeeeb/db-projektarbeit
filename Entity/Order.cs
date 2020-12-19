using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class Order
    {
        public int Id { get; set; }                                     // Id für Index
        public DateTime Date { get; set; }                              // Zeitststempel
        public Customer Customer { get; set; }                          // Kunde
        public string Comment { get; set; }                             // Kommentar für Kommission
        public virtual ICollection<Position> Positions { get; set; }    // Liste von Postionen mit Artikel
    }
}
