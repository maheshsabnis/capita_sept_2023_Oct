// See https://aka.ms/new-console-template for more information
using CS_SImpleOOps;

Console.WriteLine("Demo Simple OOPs");
MathOperations op = new MathOperations();
//double x,y;
//Console.WriteLine("Enter x");
//x = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter y");
//y = Convert.ToDouble(Console.ReadLine());

//var z = op.Power(x,y);

//Console.WriteLine($"{x} raised to {y} = {z}");

int a = 100;
int b = 200;
Console.WriteLine($"Ininitial a = {a} and b = {b}");
op.XChange(ref a, ref b);

Console.WriteLine($"In caller xchanged values a = {a} and b = {b}");

// Inline out declaration .NET 5+
// C# 9.0+
op.SumSquarer(a, b, out int c);
Console.WriteLine($" {a + b} square = {c}");

Console.ReadLine();
