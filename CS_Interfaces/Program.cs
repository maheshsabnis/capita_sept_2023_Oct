// See https://aka.ms/new-console-template for more information
using CS_Interfaces.interfaces;
using CS_Interfaces.logic;

Console.WriteLine("DEMO Interfaces");

BasicMath m1 = new BasicMath();
Console.WriteLine($"Add = {m1.Add(10,20)}");
Console.WriteLine($"Subtract = {m1.Subtract(55, 33)}");

// m2 is interface reference that is instantiated by MathExplicit class
// because the MathExplicit class implements IMath
IMath m2 = new MathExplicit();
Console.WriteLine($"Add IMath Explicit = {m2.Add(10, 20)}");
Console.WriteLine($"Subtract IMath Explicit  = {m2.Subtract(55, 33)}");

IAdvMath m3 = new MathExplicit();
Console.WriteLine($"Add IAdvMath Explicit = {m3.Add(10, 20)}");
Console.WriteLine($"Subtract IAdvMath Explicit  = {m3.Subtract(55, 33)}");

MathExplicit m4 = new MathExplicit();

Console.WriteLine($"Power = {m4.Power(5,10)}");

Console.WriteLine($"Access IMath Method Add : {((IMath)m4).Add(444,555)}");
Console.WriteLine($"Access IMath Method Subtract : {((IMath)m4).Subtract(444, 555)}");


Console.WriteLine($"Access IAdvMath Method Add : {((IAdvMath)m4).Add(444, 555)}");
Console.WriteLine($"Access IAdvMath Method Subtract : {((IAdvMath)m4).Subtract(444, 555)}");
Console.ReadLine();
