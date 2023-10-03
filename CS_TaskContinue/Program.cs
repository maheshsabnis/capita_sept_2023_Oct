// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task Continue");

Task T = Task.Factory.StartNew(() =>
{
    Console.WriteLine("TAsk 1");
    Thread.Sleep(1000);
}).ContinueWith((t1) =>
{
    Console.WriteLine($"State of T1 : {t1.IsCompletedSuccessfully}");
    Console.WriteLine("Task 2");
}).ContinueWith((t2) =>
{
    Console.WriteLine($"State of T2 : {t2.IsCompletedSuccessfully}");
    Console.WriteLine("Task 3");
});


Console.ReadLine();
