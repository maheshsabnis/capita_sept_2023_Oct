using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Event.Logic
{
    /// <summary>
    /// Class will listen to events raised by banking
    /// </summary>
    internal class EventListener
    {
        Banking bank;

        /// <summary>
        /// This class is coupled with Banking class
        /// to listene the notification for events
        /// </summary>
        /// <param name="b"></param>
        public EventListener(Banking b)
        {
            bank = b;
            // 4. Subscribe to events and invoke Notification Logic (Numbering Continue from Banking.cs)

            bank.OnOverBalance += Bank_OnOverBalance;
            bank.OnUnderBalance += new TransactionHandler(Bank_OnUnderBalance);

        }

        private void Bank_OnOverBalance(decimal amount)
        {
            decimal taxableAmount = amount - 100000;
            decimal tax = taxableAmount * Convert.ToDecimal(0.2);
            Console.WriteLine($"Dear Customer, your NetBalance is Rs.{amount}/- which is Rs.{taxableAmount}/- more than Rs 100000, so please pay tax of Rs.{tax}/-, else Mr. Modi will ctach you.");
        }

        private void Bank_OnUnderBalance(decimal amount)
        {
            Console.WriteLine($"Your netbalance is Rs. {amount}, youi must maintain minimum Rs. 5000/-");
        }
    }
}
