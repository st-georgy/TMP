namespace composite
{
    public class BankAccount : Account
    {
        private decimal balance;

        public BankAccount(string accountNumber, decimal balance) : base(accountNumber) =>
            this.balance = balance;

        public override decimal GetBalance() =>
            balance;
    }
}
