﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JwtApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

        //Nav Props
        public List<Product>? Products { get; set; }
    }
}
