namespace csharp_programming
{
    public class SavingsAccount : Account
    {

        private double MinimumBalance { get; set; }

        public SavingsAccount(double minimumBalance, double balance = 0) : base(balance)
        {
            this.MinimumBalance = minimumBalance;
        }

        public override void Withdraw(double balance)
        {
            if (this.Balance - balance < MinimumBalance)
            {
                throw new Exception("Not a valid balance to withdrow");
            }

            this.Balance -= balance;
        }

    }
}
