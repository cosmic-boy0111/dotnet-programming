
namespace csharp_programming
{
    public class Account
    {
        static int accountCount = 0;
        private int AccountNumber { get; set; }
        protected double Balance { get; set; }
        private double InterestRate { get; set; }

        public Account(double inititalBalance = 0)
        {
            Balance = inititalBalance;
            AccountNumber = accountCount++;
            InterestRate = 1.2;
        }

        public void Deposit(double balance)
        {
            Balance += balance;
        }

        public virtual void Withdraw(double balance)
        {
            if (Balance - balance < 0)
            {
                throw new Exception("Balance is not sufficient");
            }
            Balance -= balance;
        }

        public double CalculateInterest(int period)
        {
            return Balance * (InterestRate / 12) * period;
        }

    }
}
