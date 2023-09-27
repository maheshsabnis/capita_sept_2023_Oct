// See https://aka.ms/new-console-template for more information
using CS_Generic_Stack;
using System.Data.SqlTypes;
using System.Text.Json;
Console.WriteLine("Demo Custom Generic");
GenericStack<int> intStack = new GenericStack<int>();

intStack.Push(10);
intStack.Push(20);
intStack.Push(30);
intStack.Push(40);
intStack.Push(50);

var intValues = intStack.Show();

Console.WriteLine($"Data in Stack : {JsonSerializer.Serialize(intValues)}");

Console.WriteLine($"Poped Value : {intStack.Pop()}");


ConstraintsStack<Customer> customers = new ConstraintsStack<Customer>();
customers.Push(new Customer() { CustomerId = 1, CustomerName = "C1" });
customers.Push(new Customer() { CustomerId = 2, CustomerName = "C2" });
customers.Push(new Customer() { CustomerId = 3, CustomerName = "C3" });
customers.Push(new Customer() { CustomerId = 4, CustomerName = "C4" });
customers.Push(new Customer() { CustomerId = 5, CustomerName = "C5" });

var data = customers.Show();
Console.WriteLine($"Data in Stack : {JsonSerializer.Serialize(data)}");


TypeRestrictedStack<Customer> c = new   TypeRestrictedStack<Customer>();
TypeRestrictedStack<Employee> e = new TypeRestrictedStack<Employee>();
 
// Following Line Genberate Error
//TypeRestrictedStack<Product> p = new TypeRestrictedStack<Product>();

Console.ReadLine();
