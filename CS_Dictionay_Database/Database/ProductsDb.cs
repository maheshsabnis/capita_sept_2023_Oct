using CS_Dictionay_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dictionay_Database.Database
{
    internal class ProductsDb : Dictionary<string, List<Product>>
    {
        public ProductsDb()
        {
            Add("Electronics", new List<Product>() { 
               new Product(){ProductId=1,ProductName="Laptop",Price=120000},
               new Product(){ProductId=2,ProductName="Mobile",Price=20000},
               new Product(){ProductId=3,ProductName="TV",Price=70000},
               new Product(){ProductId=4,ProductName="Hard-Disk",Price=5000},
            });

            Add("Electrical", new List<Product>() {
               new Product(){ProductId=5,ProductName="Washing MAchine",Price=40000},
               new Product(){ProductId=6,ProductName="Oven",Price=30000},
               new Product(){ProductId=7,ProductName="Dishwasher",Price=60000},
               new Product(){ProductId=8,ProductName="Iron",Price=5000},
            });
        }
    }
}
