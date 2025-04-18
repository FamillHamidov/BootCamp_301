﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_EntityLayer.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
