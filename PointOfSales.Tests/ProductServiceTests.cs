using PointOfSales.Models;
using PointOfSales.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PointOfSales.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void ProductStockIncreasesWhenAdded() 
        {
            Product p = new Product();
            p.Stock = 500;
            p.Name = "Thermometer";

            ProductService ps = new ProductService(p);
            ps.AddToStock(40);
            Assert.Equal(540, p.Stock);
        }

        [Fact]
        public void ProductStockDecreasesWhenSold()
        {
            Product p = new Product();
            p.Stock = 500;
            p.Name = "Thermometer";

            ProductService ps = new ProductService(p);
            ps.RemoveFromStock(40);
            Assert.Equal(460, p.Stock);
        }
    }
}
