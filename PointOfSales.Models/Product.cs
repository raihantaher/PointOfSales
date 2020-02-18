using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSales.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double BuyPrice { get; set; }
        public int Stock { get; set; }
        public Company Company { get; set; }
    }
}
