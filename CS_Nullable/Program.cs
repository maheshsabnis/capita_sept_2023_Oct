// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Nullable");

string? name=null;


Console.WriteLine($"Name = {name}");
Console.WriteLine("Enter Name");
name = Console.ReadLine();

if (name != null)
{
    Console.WriteLine($"Name = {name}");
}
else
{
    // Some Other code
}


Console.ReadLine();
