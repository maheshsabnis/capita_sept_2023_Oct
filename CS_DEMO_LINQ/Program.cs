// See https://aka.ms/new-console-template for more information
using CS_DEMO_LINQ.Database;
using CS_DEMO_LINQ.Model;
using System.Text.Json;

Console.WriteLine("DEMO LINQ");

ProductDb db = new ProductDb();

// 1. Query using Extension Methods
var allProducts = db.Select(p=>p);
Console.WriteLine("All Products");
PrintResult(allProducts);
Console.WriteLine();

// 2. Read with Where()

var allECTProducts = db.Where(p=>p.CategoryName == "ECT");
Console.WriteLine("All ECT Products"); 
PrintResult(allECTProducts);
Console.WriteLine();

// 3. GroupBy
// The Property on which the Group is created will become a 'Key'
// In this case the CategoryName is Key
var allECTGroup = db.GroupBy(p => p.CategoryName).Select(p => p.Key);

// 4. Order By

var orderByProductName = db.OrderBy(p => p.ProductName);
Console.WriteLine("All Products in Ascending Order by Product NAme");
PrintResult(orderByProductName);
Console.WriteLine();


var orderByProductNameDescending = db.OrderByDescending(p => p.ProductName);
Console.WriteLine("All Products in Descending Order by Product NAme");
PrintResult(orderByProductNameDescending);
Console.WriteLine();

Console.WriteLine("All Together");

var result1 = db.Where(p => p.CategoryName == "ECL")
                .OrderByDescending(p => p.ProductName)
                .Select(p => p);
PrintResult(result1);

Console.WriteLine();


// Inperative Queruries


var result2 = from prd in db
              where prd.CategoryName == "IT" // First Execution
              orderby prd.ProductName descending // Second Execution
              select prd; // Always Last executed to get final result
PrintResult(result2);

// Using Group
Console.WriteLine("Group By CategoryName to Calculate Sum of price of price of each category");

var groupResult = from prd in db
                  group prd by prd.CategoryName into gp
                  select new
                  {
                      CategoryName = gp.Key,
                      SumPrice = gp.Sum(p => p.Price),
                  };
Console.WriteLine($" Category wise sum = {JsonSerializer.Serialize(groupResult)}");





Console.ReadLine();


static void PrintResult(IEnumerable<Product> products)
{
    Console.WriteLine(JsonSerializer.Serialize(products));
}