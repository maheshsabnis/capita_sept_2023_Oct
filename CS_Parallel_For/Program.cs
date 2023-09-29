// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("DEMO Parallel Class");

Console.WriteLine("Sequential Call using for..loop");

// 1. Define a timer
var sequential = Stopwatch.StartNew();
var empList = new EmployeeList();
for (int i = 0; i < empList.Count; i++)
{
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Sequentialy Calaculated Tax for EmpNo : {empList[i].EmpNo} is  = {empList[i].TDS}");
}

Console.WriteLine($"Total Time for Sequential Execution is = {sequential.Elapsed.TotalSeconds}");

Console.WriteLine("Sequential Call Ends here");
Console.WriteLine();
Console.WriteLine("Using Parallel Execution");
var parallel = Stopwatch.StartNew();

Parallel.For(0, empList.Count, (i) => {
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Parallely Calaculated Tax for EmpNo : {empList[i].EmpNo} is  = {empList[i].TDS}");
});

Console.WriteLine($"Total Time for Parallel Execution is = {parallel.Elapsed.TotalSeconds}");


Console.ReadLine();
