// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Mai Thread");

Thread t1 = new Thread(Increament);
Thread t2 = new Thread(Decreament);
t1.Start();
//t1.Join();
t2.Start();

Console.WriteLine("Doing Something on Main Thread");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Main Thread i = {i}");
}

Console.WriteLine();

Console.ReadLine();

static void Increament()
{
    Console.WriteLine("Increament on Seperate Tharead Started");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Increament: {i}");
    }
    Console.WriteLine("End of Increment");
}

static void Decreament()
{
    Console.WriteLine("Decreament on Seperate Tharead Started");
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine($"Decreament: {i}");
    }
    Console.WriteLine("End of Decrement");
}