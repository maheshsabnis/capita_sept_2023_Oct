using CS_Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces.logic
{
    /// <summary>
    /// Explicit Implementation
    /// </summary>
    internal class MathExplicit : BaseClass, IMath, IAdvMath 
    {
        int IMath.Add(int x, int y) 
        {
            return x + y; 
        }

        int IAdvMath.Add(int x, int y)
        {
            return (x * x) + 2 * x * y + (y * y);
        }

        int IMath.Subtract(int x, int y) 
        { 
            return x - y; 
        }

        int IAdvMath.Subtract(int x, int y)
        {
            return (x * x) - 2 * x * y + (y * y);
        }
    }
}
