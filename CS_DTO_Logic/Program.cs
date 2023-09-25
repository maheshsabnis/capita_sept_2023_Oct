// See https://aka.ms/new-console-template for more information
using CS_DTO_Logic.Logic;
using CS_DTO_Logic.Models;

Console.WriteLine("DEMO DTO and Logic");

EmployeeLogic logic = new EmployeeLogic();

Employee emp1 = new Employee() 
{
    EmpNo=101, EmpName="Mahesh",DeptName="IT",Designation="Manager", Salary=40000
};

logic.AddEmployee(emp1);

Employee emp2 = new Employee()
{
    EmpNo = 102,
    EmpName = "Tejas",
    DeptName = "HR",
    Designation = "Lead",
    Salary = 30000
};

var employees = logic.AddEmployee(emp2);

foreach (Employee emp in employees)
{
    Console.WriteLine($"EmpNo : {emp.EmpNo} EmpName: {emp.EmpName} DeptName: {emp.DeptName} Designation: {emp.Designation} Salary: {emp.Salary}");
}




Console.ReadLine();    
