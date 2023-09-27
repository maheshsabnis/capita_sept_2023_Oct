using CS_Inheritence.Database;
using CS_Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Logic
{
    internal class ManagerLogic : EmployeeLogic
    {
        Manager[] managers = new Manager[4];
        int counter = 0;
        public override void AddEmployee(Employee emp)
        {
            managers[counter++] = (Manager)emp;

            ApplicationDB.EmployeesDb?.Add(emp);
        }
        public override Employee[] GetEmployee()
        {
            return ApplicationDB.EmployeesDb.ToArray();
            //return managers;
        }
        public override decimal CalculateSalary(Employee emp)
        {
            var sal = base.CalculateSalary(emp);

            Manager m = (Manager)emp;

            decimal netSalary = sal + m.OT + m.DA;

            return netSalary;
        }
    }
}
