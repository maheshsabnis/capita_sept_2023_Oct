using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaxCalculator.Interfaces
{
    internal interface ITaxCalculator
    {
        double CalculateTax(double amount);
    }
}
