namespace composite
{
    public abstract class Account
    {
        protected string accountNumber;

        public Account(string accountNumber) =>
            this.accountNumber = accountNumber;

        public abstract decimal GetBalance();
    }
}
