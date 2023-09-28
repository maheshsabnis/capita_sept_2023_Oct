// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;

Console.WriteLine("Hello, World!");

int x, y, z;

Console.WriteLine("Enter x");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y");
y = Convert.ToInt32(Console.ReadLine());

z = x + y;
// The Template String aka string interpolation
Console.WriteLine($"z = {z}");



 