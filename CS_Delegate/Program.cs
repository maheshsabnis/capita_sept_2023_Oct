// define a delegate

using System.Reflection.Metadata.Ecma335;

namespace CS_Delegate
{
    // Declare delegate at namespace level
    public delegate int OperationHandler(int x, int y);
    class Program
    {
        static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("DEMO Delegate");

            // 1. Direct Access to a Method
            Console.WriteLine($"Add Direct Access : {Add(20, 30)} ");
            // 2.
            Console.WriteLine("Using Delegate C# 1.x");
            // 2.a. Define a delegate type and pass method address to it
            // Method name itself is an address
            OperationHandler handler1 = new OperationHandler(Add);
            // 2.b. Pass Parameters to the delegate type instance
            // This will intarnally invoke method based on address and
            // execute it
            var result = handler1(10, 20);
            Console.WriteLine($"Add usign Delegate {result}");
            Console.WriteLine("C# 2.0 Anonymous method");
            OperationHandler handler2 = delegate (int x, int y) { return x + y; };
            Console.WriteLine($"Add using Anonymous method {handler2(100,200)}");
            Console.WriteLine($"using a Lambda Expression C# 3.0");
            OperationHandler handler3 = (x,y)=> { return x * y; };
            Console.WriteLine($"using Lambda expression : {handler3(200,500)}");

            Console.WriteLine("Method with Lambda");
            Bridge((x, y) => { return x * y; });
            Bridge((x, y) => { return x + y; });
            Bridge((x, y) => { return x - y; });

            Console.ReadLine();
        }


        // a method
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Bridge(OperationHandler handler)
        {
            Console.WriteLine($"Result of Opetration: {handler(10,20)}");
        }

    }
}






;
