using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    public abstract class BankAccount
    {
        protected string AccountNumber;
        protected decimal Balance;

        public BankAccount(string AccountNumber, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        public abstract void Deposit(decimal amt);
        public abstract void balance(decimal amt);

        public void PrintBalance()
        {
            Console.WriteLine($"Current Balance for Account {AccountNumber}: ${Balance}");

        }

    }

    // public class SavingsAccount : BankAccount
    //{
      
    //}

    //public class checkingAccount : BankAccount
    //{

    //}


    internal class Banking
    {
            public static void Main(string[] args)
            { 
            }
    }
}
