using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Collection
{
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptName { get; set; }
        public decimal Salary { get; set; }
        /* The Type property will have repeated values for each employee so better remove Type property and instead create a new class for each type so that each new class will have properties scoped to that class only */
        //public string? Type { get; set; }
        //public decimal HRA { get; set; }
        //public decimal TA { get; set; }
    }

}
