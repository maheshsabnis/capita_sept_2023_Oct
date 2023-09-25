using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DTO_Logic.Models
{
    /// <summary>
    /// DTO or Entity Class
    /// </summary>
    internal class Employee
    {
        // Read/Write Property
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptName { get; set; }
        public string? Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
