﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db_projektarbeit
{
    class Product
    {
        public int Id { get; set; }
        public int ProductNr { get; set; }
        public int GroupId { get; set; }
        public ProductGroup Group { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
