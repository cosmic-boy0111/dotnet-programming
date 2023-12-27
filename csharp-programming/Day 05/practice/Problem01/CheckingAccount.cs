namespace csharp_programming
{
    public class CheckingAccount : Account
    {
        private double OverdraftLimit { get; set; }

        public CheckingAccount(double overdraftLimit, double balance) : base(balance)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double balance)
        {
            if (this.Balance - balance < OverdraftLimit)
            {
                throw new Exception("limit is over");
            }
            this.Balance -= balance;
        }

    }
}
