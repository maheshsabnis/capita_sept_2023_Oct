// See https://aka.ms/new-console-template for more information
using CS_Parallel_Invoke.Logic;

Console.WriteLine("Parallel Invoke to Perform Multiple Operations");
string jamesInfo = String.Empty;
string ethanInfo = String.Empty;

FileOperations op   = new FileOperations();

// Invoke Methods Parallelly

Parallel.Invoke(() => 
{
    jamesInfo = op.ReadJames();
    ethanInfo = op.ReadEthan();
});

Console.WriteLine($"James = {jamesInfo}");
Console.WriteLine($"Ethan = {ethanInfo}");


Console.ReadLine();
