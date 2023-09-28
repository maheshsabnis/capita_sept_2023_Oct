using CS_TaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaxCalculator.TaxGateway
{
    internal class TaxCalculator
    {
        /// <summary>
        /// Polymorphic Behavior based on Type That is implementing
        /// ITaxCalculator i.e. either TDSCalculator or GSTCalculator
        /// </summary>
        /// <param name="taxCalculator"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double GetTax(ITaxCalculator taxCalculator, double amount)
        { 
            return taxCalculator.CalculateTax(amount);
        }
    }
}
