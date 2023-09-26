using CS_Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Logic
{
    internal class DirectorLogic : EmployeeLogic
    {
        private Director[] directors = new Director[4];
        int counter = 0;
        /// <summary>
        /// The Abstract memeber of the Base class is implemented
        /// using a new Logic
        /// </summary>
        /// <param name="emp"></param>
        public override void AddEmployee(Employee emp)
        {
            /* While Storing Higher Order Object in Class Tree in an array on the Lower Order object's array of the tree make sure that the higher object you typecast */
            directors[counter++] = (Director)emp;
        }
        public override Employee[] GetEmployee()
        {
            return directors;
        }

        public override decimal CalculateSalary(Employee emp)
        {
           var sal =  base.CalculateSalary(emp);

           Director d = (Director)emp;

            decimal netSalary = sal + d.HRA + d.TA + d.DA + d.FoodAllowance;
            
            return netSalary;
        }
    }
}
