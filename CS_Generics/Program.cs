using CS_Generics;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Generics");
List<int> intList = new List<int>();
intList.Add(10);
intList.Add(20);
intList.Add(30);
intList.Add(40);
Console.WriteLine("Integer List");
foreach (int i in intList)
{
    Console.WriteLine(i);
}
Console.WriteLine("Ends Here");
Console.WriteLine();
Console.WriteLine("String List");
List<string> strList = new List<string>();
strList.Add("Tejas");
strList.Add("Mahesh");
strList.Add("Rameshrao");
strList.Add("Ramrao");
strList.Add("Sabnis");

foreach (string str in strList)
{
    Console.WriteLine(str); ;
}

Console.WriteLine("Ends Here");
Console.WriteLine();
Console.WriteLine("Employee List");
List<Employee> empList = new List<Employee>();
empList.Add(new Employee() { EmpNo=101,EmpName="Narendra"});
empList.Add(new Employee() { EmpNo = 101, EmpName = "Amit" });

foreach (Employee emp in empList)
{
    Console.WriteLine(emp.EmpNo + " " + emp.EmpName);
}

Console.ReadLine();
