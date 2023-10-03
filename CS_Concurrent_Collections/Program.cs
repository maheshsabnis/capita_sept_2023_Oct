// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;

namespace CS_Concurrent_Collections
{
    class Program
    {
        //static Dictionary<int, string> dataDictionary = new Dictionary<int, string>();
        static ConcurrentDictionary<int, string> dataDictionary = new ConcurrentDictionary<int, string>();
        static void Main()
        {
            Console.WriteLine("Using Concurrent Collections");

            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            foreach (var item in dataDictionary)
            {
                Console.WriteLine($"Key : {item.Key} and Value: {item.Value}");
            }

            Console.ReadLine();

        }

        static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                //dataDictionary.Add(i, $"Added by Mathod 1 {i}");
                dataDictionary.TryAdd(i, $"Added by Mathod 1 {i}");
                Thread.Sleep(100);
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                //dataDictionary.Add(i, $"Added by Mathod 2 {i}");
                dataDictionary.TryAdd(i, $"Added by Mathod 2 {i}");
                Thread.Sleep(100);
            }
        }
    }
}




