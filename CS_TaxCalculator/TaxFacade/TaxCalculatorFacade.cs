using CS_TaxCalculator.Interfaces;
using CS_TaxCalculator.Logic;
using CS_TaxCalculator.TaxGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaxCalculator.TaxFacade
{
    internal class TaxCalculatorFacade
    {
        public double CalculateTax(double amount, string taxType)
        { 
            TaxCalculator calculator = new TaxCalculator();
            ITaxCalculator taxCalc;
            double tax = 0; ;
            if (taxType == "TDS")
            {
                taxCalc = new TDSCalculator();
                tax = calculator.GetTax(taxCalc, amount);
            }

            if (taxType == "GST")
            {
                taxCalc = new GSTCalculator();
                tax = calculator.GetTax(taxCalc, amount);
            }

            return tax;
        }
    }
}
