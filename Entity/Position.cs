﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class Position
    {
        public int Id { get; set; }             // Id für Index
        public int Counter { get; set; }        // Anzahl der Itemes
        public decimal Total { get; set; }      // gesammt Summe aller Artikel
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }   // Product
    }
}
