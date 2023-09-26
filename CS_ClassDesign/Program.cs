// See https://aka.ms/new-console-template for more information
using CS_ClassDesign;
 

Console.WriteLine("DEMO For Better Class Design");
Customer Cust1 = new Customer(101,"James Bond", "MI16 London");
Cust1.AddCustomer(Cust1);
//Customer Cust2 = new Customer(102, "Ethan Hunt", "IMF Washington");
//Cust2.AddCustomer(Cust2);
Cust1 = new Customer(102, "Ethan Hunt", "IMF Washington");
Cust1.AddCustomer(Cust1);

var customers = Cust1.GetCustomers();

foreach (var customer in customers)
{
    Console.WriteLine($"CustId :{customer}");
}


Console.ReadLine();   
