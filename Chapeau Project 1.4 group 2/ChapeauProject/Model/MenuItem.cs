﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Card { get; set; }

        public decimal Price { get; set; }

        public int? Stock { get; set; }

        public decimal? VAT { get; set; }
    }
}
