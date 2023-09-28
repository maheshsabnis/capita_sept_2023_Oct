using CS_TaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaxCalculator.Logic
{
    internal class TDSCalculator : ITaxCalculator
    {
        double ITaxCalculator.CalculateTax(double amount)
        {
            double tax = 0;
            if (amount <= 100000)
            {
                tax = amount * 0.2;
            }
            if (amount > 100000 && amount <= 500000)
            {
                tax = amount * 0.4;
            }
            return tax;    
        }
    }
}
