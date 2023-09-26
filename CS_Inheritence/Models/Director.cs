using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    internal class Director : Employee
    {
        public decimal HRA { get; set; }
        public decimal TA { get; set;}
        public decimal DA { get; set; }
        public decimal FoodAllowance { get; set; }
    }
}
