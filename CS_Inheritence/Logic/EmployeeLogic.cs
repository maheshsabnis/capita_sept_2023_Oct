
using CS_Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Logic
{
    //internal class EmployeeLogic
    //{
    //    Employee[] employees;
    //    int ctr = 0;
    //    public EmployeeLogic()
    //    {
    //        employees = new Employee[4];
    //    }

    //    public void AddEmployee(Employee e)
    //    {
    //        employees[ctr++] = e;
    //    }
    //    public Employee[] GetEmployees() 
    //    {
    //        return employees;
    //    }
    //    public decimal CalculateSalary(Employee e)
    //    {
    //        return e.Salary;
    //    }
    //}

    internal abstract class EmployeeLogic
    {
        public abstract void AddEmployee(Employee emp);
        public abstract Employee[] GetEmployee();
        public virtual decimal CalculateSalary(Employee emp)
        {
            /*Deduction of Professinal Tax */
            return emp.Salary - 200;
        }
    }
}
