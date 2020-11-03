using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simuating a deposit {amount, 0:c} into balance");
            _balance = amount;
        }
        
        public double GetBalance()
        {
            return _balance;
        }
    }
    
}
