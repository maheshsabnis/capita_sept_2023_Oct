using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ClassDesign
{
    internal class Customer
    {
        /*Attribute as Private Members*/
        private int _CustId = 0;
        private string? _CustName;
        private string? _CustAddress;

        Customer[] customers;
        int counter = 0;
        /// <summary>
        /// Initial Lize the Private Memebrs
        /// </summary>
        public Customer(int custId, string custname, string addr) 
        {
            _CustId=custId;
            _CustName=custname;
            _CustAddress=addr;

            customers = new Customer[2];
        }

        public void AddCustomer(Customer c)
        {
            customers[counter++] = c;
        }

        public Customer[] GetCustomers()
        {
            return customers;
        }
    }
}
