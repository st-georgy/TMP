namespace builder
{
    public class BankAccountBuilder : IBankAccountBuilder
    {
        private BankAccount _bankAccount;

        public BankAccountBuilder() =>
            _bankAccount = new BankAccount();

        public void SetAccountNumber(string accountNumber) =>
            _bankAccount.AccountNumber = accountNumber;

        public void SetBalance(decimal balance) =>
            _bankAccount.Balance = balance;

        public void SetAccountHolder(string accountHolder) =>
            _bankAccount.AccountHolder = accountHolder;

        public void SetAccountType(string accountType) =>
            _bankAccount.AccountType = accountType;

        public BankAccount GetBankAccount() =>
            _bankAccount;
    }
}
