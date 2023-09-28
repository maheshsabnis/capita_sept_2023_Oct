// See https://aka.ms/new-console-template for more information
using CS_CollectionRead.Database;
using System.Text.Json;

Console.WriteLine("DEMO Collection Reading");

ProductDb db = new ProductDb();
// Iteration
foreach (var prd in db)
{
    // Defining Read Conditions
    if (prd.CategoryName == "ECT" && prd.Price > 5000)
    {
        // Printing as Output
        Console.WriteLine(JsonSerializer.Serialize(prd));
    }
}


Console.ReadLine();
