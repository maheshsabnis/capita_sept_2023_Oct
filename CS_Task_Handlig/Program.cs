// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hadling TAsks with Wait");
Task t1 = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Task 1");
}); 



Task t2 = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Task 2");
});


Task t3 = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Task 3");
});

t1.Wait();
t2.Wait();
t3.Wait();



Task.WaitAny(t1);
Console.ReadLine();
