using System.Xml.Linq;

namespace csharp_programming
{
    internal class Problem{
        
        public static void Main()
        {
            Account a = new Account();
            a.Deposit(1000);
            a.Withdraw(100);
            Console.WriteLine(a.CalculateInterest(12));

            SavingsAccount s = new SavingsAccount(100,1000);
            s.Withdraw(1000);

            CheckingAccount c = new CheckingAccount(1000,1000);
            c.Withdraw(2000);
            c.Withdraw(100);
            
        }

    }
}
