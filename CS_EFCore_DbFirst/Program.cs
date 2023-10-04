// See https://aka.ms/new-console-template for more information
using CS_EFCore_DbFirst.Logic;
using CS_EFCore_DbFirst.Models;
using System.Text.Json;

Console.WriteLine("DEMO EF Core DB First");

IDataAccessRepository<Department,int> deptDbAccess = new DepartmentDataAccessRepository();

//1. Read All Departments

var depts = await deptDbAccess.GetAsync();

Console.WriteLine($"All Data : {JsonSerializer.Serialize(depts)}");

Console.WriteLine();
Console.WriteLine("Adding New Department");

var newDept = await deptDbAccess.CreateAsync(new Department() { DeptNo=40,DeptName="AC",Location="Mumbai",Capacity=75 });

Console.WriteLine("Aftre Adding NEw Record");

depts = await deptDbAccess.GetAsync();

Console.WriteLine($"All Data : {JsonSerializer.Serialize(depts)}");

var updateRecord = await deptDbAccess.UpdateAsync(10, new Department() 
{
  DeptNo=10,DeptName="IT-ES",Location="Pune-East",Capacity=3000
});

depts = await deptDbAccess.GetAsync();

Console.WriteLine($"All Data After Update: {JsonSerializer.Serialize(depts)}");

var dept = deptDbAccess.DeleteAsync(40);
// Wait so that delete is completed and then star readig all records again
Thread.Sleep(1000);

depts = await deptDbAccess.GetAsync();

Console.WriteLine($"All Data After Delete: {JsonSerializer.Serialize(depts)}");






