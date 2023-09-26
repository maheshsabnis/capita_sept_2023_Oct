// See https://aka.ms/new-console-template for more information
using CS_Inheritence.Accounts;
using CS_Inheritence.Logic;
using CS_Inheritence.Models;

Console.WriteLine("DEMO Inheritence");
Employee e1 = new Director() { EmpNo=1,EmpName="A",DeptName="D1",Salary=1000,HRA=400,TA=200,DA=500,FoodAllowance=100 };
Employee e2 = new Director() { EmpNo = 2, EmpName = "B", DeptName = "D2", Salary = 2000, HRA = 400, TA = 200, DA = 500, FoodAllowance = 100 };
Employee e3 = new Director() { EmpNo = 3, EmpName = "C", DeptName = "D1", Salary = 3000, HRA = 400, TA = 200, DA = 500, FoodAllowance = 100 };
Employee e4 = new Director() { EmpNo = 4, EmpName = "D", DeptName = "D2", Salary = 4000, HRA = 400, TA = 200, DA = 500, FoodAllowance = 100 };

EmployeeLogic logic = new DirectorLogic();

logic.AddEmployee(e1);
logic.AddEmployee(e2);
logic.AddEmployee(e3);
logic.AddEmployee(e4);

var emps = logic.GetEmployee();


Accountancy accountancy = new Accountancy();


foreach (var emp in emps)
{
    Console.WriteLine($"Net Salary of Director EmpNo: {emp.EmpNo} is = ${logic.CalculateSalary(emp)} and Tax is  {accountancy.GetTax(emp,logic)}");
}



 e1 = new Manager() { EmpNo = 5, EmpName = "E", DeptName = "D1", Salary = 1000, OT = 260, DA = 510 };
 e2 = new Manager() { EmpNo = 6, EmpName = "F", DeptName = "D2", Salary = 2000, OT = 270, DA = 520 };
 e3 = new Manager() { EmpNo = 7, EmpName = "G", DeptName = "D1", Salary = 3000, OT = 280, DA = 540 };
 e4 = new Manager() { EmpNo = 8, EmpName = "H", DeptName = "D2", Salary = 4000, OT = 290, DA = 530 };



 logic = new ManagerLogic();

logic.AddEmployee(e1);
logic.AddEmployee(e2);
logic.AddEmployee(e3);
logic.AddEmployee(e4);

 emps = logic.GetEmployee();





foreach (var emp in emps)
{
    Console.WriteLine($"Net Salary of Manager EmpNo: {emp.EmpNo} is = ${logic.CalculateSalary(emp)}  and Tax is  {accountancy.GetTax(emp, logic)}");
}


Console.ReadLine();
