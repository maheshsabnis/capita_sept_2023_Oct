// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Boxing UnBoxung");

string x = "10";
//Boxing
object o = x;

Console.WriteLine($"Type stored in Object o is = {o.GetType()} and value in Object o is = {o}  ");
// UnBoxing: FIrst Verify the type based on Casting and the read data from Object
int y = (int)o;

Console.WriteLine($"y = {y}");

Console.ReadLine();