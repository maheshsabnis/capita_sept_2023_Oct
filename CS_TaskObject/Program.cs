// See https://aka.ms/new-console-template for more information
using CS_TaskObject.Logic;

Console.WriteLine("DEMO Task Object");

FileOperations fileOperations = new FileOperations();

// Define Tasks .NET Frwk 4.0

try
{
	Task<string> t1 = Task.Factory.StartNew<string>(() =>
    {
        string str = fileOperations.ReadJames();
        return str;
    });

    string res1 = t1.Result;
    Console.WriteLine($"Result 1 = {res1}");
}
catch (Exception ex)
{

	Console.WriteLine($"The FIle migt be not available for reading");
}

Task<string> t2 = Task.Factory.StartNew<string>(() =>
{
    string str = fileOperations.ReadEthan();
    return str;
});


// Start Tasks to receive results


string res2 = t2.Result;

Console.WriteLine();
Console.WriteLine($"Result 2 = {res2}");


Console.ReadLine();
