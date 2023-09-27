using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Generic_Stack
{
    internal abstract class EntityBase
    { 
    }

    internal class Customer : EntityBase
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
    }
    internal class Employee : EntityBase
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
    }

    internal class Product  
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
    }
}
