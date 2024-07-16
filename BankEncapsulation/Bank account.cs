using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class bankAccount
    {
        public bankAccount() 
        { 
        }

        private double balance = 0;

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }
    }
}
