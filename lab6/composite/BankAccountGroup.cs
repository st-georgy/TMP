namespace composite
{
    public class BankAccountGroup : Account
    {
        private List<Account> accounts;

        public BankAccountGroup(string accountNumber) : base(accountNumber) =>
            accounts = new List<Account>();

        public void AddAccount(Account account) =>
            accounts.Add(account);

        public override decimal GetBalance()
        {
            decimal totalBalance = 0;
            foreach (var account in accounts)
                totalBalance += account.GetBalance();
            return totalBalance;
        }
    }
}
