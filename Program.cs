using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine("How much would you like to deposit today?");
            double amounttoDeposit = double.Parse(Console.ReadLine());
            ba.Deposit(amounttoDeposit);
            double userBalance = ba.GetBalance();
            Console.WriteLine($"Your current balance is {userBalance, 0:c}");
        }
    }
}
