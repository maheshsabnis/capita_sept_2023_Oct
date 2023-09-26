using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_DTO_Logic.Models;

namespace CS_DTO_Logic.Logic
{
    internal class EmployeeLogic
    {
        // define a local data store
        Employee[] employees = new Employee[2];
        int counter = 0;

        // public methods
        public Employee[] GetEmployees() 
        {
            return employees; 
        }

        public Employee[] AddEmployee(Employee emp)
        {
            if (IsEmployeeExist(emp.EmpNo))
            {
                // do not accept the duplicate record
            }
            employees[counter++] = emp;
            return employees;
        }

        public Employee[] UpdateEmployee(Employee emp) 
        {
            /*Logic for Update*/
            //1. Searcg Employee in Array if found Update it and return modified array  with new values, else return not modified array

            if (IsEmployeeExist(emp.EmpNo))
            { 
            }

            return employees;
        }

        public Employee[] DeleteEmployee(Employee emp)
        {
            /*Logic for Delete*/
            //1. Searcg Employee in Array if found Delete it and return modified array  with new values, else return not modified array

            if (IsEmployeeExist(emp.EmpNo))
            {
            }
            return employees;
        }

        private bool IsEmployeeExist(int eno)
        {
            return false;
        }
    }
}
