using PointOfSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSales.Services
{
    public class ProductService
    {
        private Product Product;

        public ProductService(Product p)
        {
            this.Product = p;
        }

        public void AddToStock(int num)
        {
            Product.Stock += num;
        }

        public void RemoveFromStock(int num)
        {
            Product.Stock -= num;
        }
    }
}
