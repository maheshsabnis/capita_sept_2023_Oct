using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Event.Logic
{
    // 1. Define delegate
    public delegate void TransactionHandler(decimal amount);
    internal class Banking
    {
        decimal _NetBalance;

        // 2. Define events

        public event TransactionHandler OnOverBalance;
        public event TransactionHandler OnUnderBalance;


        public Banking(decimal netBalance)
        {
            _NetBalance = netBalance;
        }

        public void Deposit(decimal amount)
        {
            _NetBalance += amount;
            // 3. Raise Events based on condition
            if (_NetBalance > 100000)
            {
                OnOverBalance(_NetBalance);
            }
        }
        public void Withdrawal(decimal amount)
        {
            _NetBalance -= amount;
            // 3. Raise Events based on condition
            if (_NetBalance < 5000)
            {
                OnUnderBalance(_NetBalance);
            }
        }
        public decimal GetBalance() 
        {
            return _NetBalance;
        }
    }
}
