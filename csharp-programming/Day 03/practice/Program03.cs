using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{
    internal class Program03
    {
        class BankAccount
        {
            string AccountNumber { get; set; }
            string AccountHolderName { get; set; }
            double Balance { get; set; }

            public BankAccount(string accountNumber, string acoountHolderName, double balace) { 
                AccountNumber = accountNumber;
                AccountHolderName = acoountHolderName;
                Balance = balace;
            }

            public void Deposit(double balance)
            {
                this.Balance += balance;
            }

            public void Withdraw(double balance){
                if (this.Balance - balance < 0)
                    throw new Exception("withdrawal Balance not available");
                this.Balance -= balance;
            }

        }
        public static void Main()
        {
            BankAccount myAccount = new BankAccount("1275361562431436", "Gaurav Bhagat", 1000);
            myAccount.Deposit(1000);
            myAccount.Withdraw(10000);
        }
    }
}
