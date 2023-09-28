using CS_DEMO_LINQ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DEMO_LINQ.Database
{
    internal class ProductDb : List<Product>
    {
        public ProductDb()
        {
            Add(new Product() {ProductId=1,ProductName="Laptop",CategoryName="IT",Price=1000 });
            Add(new Product() { ProductId = 2, ProductName = "Iron", CategoryName = "ECL", Price = 300 });
            Add(new Product() { ProductId = 3, ProductName = "TV", CategoryName = "ECT", Price = 3000 });
            Add(new Product() { ProductId = 4, ProductName = "Mixer", CategoryName = "ECL", Price = 200 });
            Add(new Product() { ProductId = 5, ProductName = "SSD", CategoryName = "IT", Price = 5000 });
            Add(new Product() { ProductId = 6, ProductName = "Fridge", CategoryName = "ECT" +
                "", Price = 8000 });
            Add(new Product() { ProductId = 7, ProductName = "RAM", CategoryName = "IT", Price = 2000 });

        }
    }
}
