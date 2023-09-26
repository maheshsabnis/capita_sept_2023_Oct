using CS_Inheritence.Logic;
using CS_Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Accounts
{
    internal class Accountancy
    {
        /// <summary>
        /// At Runtime the 'Employee' will be replaced by an actual derived type of Emploee and 'EmployeeLogic' will be replaced by actual derived type of EmployeeLogic
        /// This is Liskov Substitution Principal Implementation
        /// In the WOrld of OOPs this is Dynamic Polymorphism
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="logic"></param>
        /// <returns></returns>
        public decimal GetTax(Employee emp, EmployeeLogic logic)
        { 
            decimal salary = logic.CalculateSalary(emp);
            decimal tax = salary * Convert.ToDecimal(0.2);
            return tax;
        }
    }
}
