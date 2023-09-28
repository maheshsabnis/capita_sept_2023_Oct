using CS_TaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaxCalculator.Logic
{
    internal class GSTCalculator : ITaxCalculator
    {
        double ITaxCalculator.CalculateTax(double amount)
        {
            return amount * 0.18;
        }
    }
}
