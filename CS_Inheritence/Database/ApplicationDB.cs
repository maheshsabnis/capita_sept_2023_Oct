using CS_Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Database
{
    /// <summary>
    /// A static modifier,
    /// This means that the class will be Thread-Safe
    /// </summary>
    internal static class ApplicationDB
    {
        public static List<Employee>? EmployeesDb { get; set; } = new List<Employee>();
    }
}
