using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SImpleOOps
{
    internal class MathOperations
    {
        public double Power(double x, double y)
        { 
            return Math.Pow(x, y);
            
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
        /// <summary>
        /// x and y are formal parameters but having different memory locations
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void XChange(ref int x, ref int y)
        {
            Console.WriteLine($"Received values x ={x} and y = {y}");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"Xchange in method values x ={x} and y = {y}");
        }


        public void SumSquarer(int x, int y, out int z)
        {
            z = (x * x) + 2 * (x * y) + (y * y);
        }
    }
}
