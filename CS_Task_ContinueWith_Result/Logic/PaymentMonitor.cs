using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Task_ContinueWith_Result.Logic
{
    internal class Payment
    {
        public decimal NetIncome { get; set; }
        public decimal TDS { get; set; }
        public decimal GST { get; set; }
        public decimal NetPayment { get; set; }
    }


    internal class PaymentMonitor
    {
        decimal _NetINcome = 0;
        decimal tds = 0;
        decimal gst = 0;
        public PaymentMonitor(decimal ni)
        {
            _NetINcome = ni;
        }


        public decimal GetTDS()
        {
            if (_NetINcome <= 0)
                throw new Exception("Value Cannot be 0 or -ve");

            if (_NetINcome > 100000)
            {
                tds = _NetINcome * Convert.ToDecimal(0.2);
            }
            else
            {
                tds = _NetINcome * Convert.ToDecimal(0.1);
            }
            return tds;
        }

        public decimal GetGST()
        {
           
            gst = _NetINcome * Convert.ToDecimal(0.18);
            return gst;
        }

        public decimal GetNetPayment(decimal netincome, decimal tds, decimal gst)
        {
            return netincome - tds + gst;
        }

    }
}
