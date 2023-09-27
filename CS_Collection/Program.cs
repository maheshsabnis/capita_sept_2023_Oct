using CS_Collection;
using System.Collections;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Collection");
ArrayList arrList = new ArrayList();

arrList.Add(10);
arrList.Add(20);
arrList.Add(30);
arrList.Add(40);
arrList.Add(50);
arrList.Add(60);
arrList.Add(40.66);
arrList.Add(50.33);
arrList.Add(60.45);
arrList.Add('A');
arrList.Add('B');
arrList.Add('C');
arrList.Add("James Bond");
arrList.Add("Jack Ryan");
arrList.Add("Ethan Hunt");
arrList.Add("Indiana Jones");
arrList.Add("Jason Bourn");

arrList.Add(new Employee() {EmpNo=101,EmpName="Mahesh",DeptName="IT",Salary=7000 });

arrList.Add(new Employee() { EmpNo = 102, EmpName = "Tejas", DeptName = "HRD", Salary = 5000 });

// Iterate

foreach (object o in arrList)
{
    if (o.GetType() == typeof(int))
    {
        Console.WriteLine($"Integer : {(int)o}");
    }
    if (o.GetType() == typeof(string))
    {
        Console.WriteLine($"String : {(string)o}");
    }
    if (o.GetType() == typeof(double))
    {
        Console.WriteLine($"Double : {(double)o}");
    }
    if (o.GetType() == typeof(char))
    {
        Console.WriteLine($"Character : {(char)o}");
    }
    if (o.GetType() == typeof(Employee))
    {
        Employee e = (Employee)o;
        Console.WriteLine($"Employee : {e.EmpNo} {e.EmpName}");
    }
}

Console.ReadLine();
