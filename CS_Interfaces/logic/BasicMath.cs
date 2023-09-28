using CS_Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces.logic
{
    /// <summary>
    /// Implicit Implementation
    /// </summary>
    internal class BasicMath : IMath, IAdvMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
