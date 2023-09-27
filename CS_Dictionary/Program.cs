// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO DIctionary");

Dictionary<int, string> kvDict = new Dictionary<int, string>();

kvDict.Add(10, "IT");
kvDict.Add(20, "HRD");
kvDict.Add(30, "SALES");
kvDict.Add(40, "ACCOUNTING");

foreach (var key in kvDict.Keys)
{
    Console.WriteLine($"Key = {key}");
}
Console.WriteLine();
foreach (var value in kvDict.Values)
{
    Console.WriteLine($"Value = {value}");
}

Console.WriteLine("Enter Key to read its value");
int key1 = Convert.ToInt32(Console.ReadLine());

var isExist = kvDict.TryGetValue(key1, out string? value1);
if (!isExist)
{
    Console.WriteLine($"Valeu for Key = {key1} is not found");
}
else
{
    Console.WriteLine($"Value = {value1}");
}


Console.ReadLine();
