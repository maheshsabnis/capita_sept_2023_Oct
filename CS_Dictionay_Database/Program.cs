using CS_Dictionay_Database.Models;
using CS_Dictionay_Database.Database;

Console.WriteLine("Dictionay Real-World In-Memory Data Store");

ProductsDb db = new ProductsDb();

var isExist = db.TryGetValue("Electronics", out List<Product>? products);

if (isExist)
{
	foreach (Product product in products)
	{
        Console.WriteLine($"{product.ProductId} {product.ProductName} {product.Price}");
    }
}


Console.ReadLine();

