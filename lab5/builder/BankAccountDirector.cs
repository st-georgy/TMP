namespace builder
{
    public class BankAccountDirector
    {
        private IBankAccountBuilder _bankAccountBuilder;

        public BankAccountDirector(IBankAccountBuilder bankAccountBuilder) =>
            _bankAccountBuilder = bankAccountBuilder;

        public void CreateBankAccount(string accountNumber, decimal balance, string accountHolder, string accountType)
        {
            _bankAccountBuilder.SetAccountNumber(accountNumber);
            _bankAccountBuilder.SetBalance(balance);
            _bankAccountBuilder.SetAccountHolder(accountHolder);
            _bankAccountBuilder.SetAccountType(accountType);
        }

        public BankAccount GetBankAccount() =>
            _bankAccountBuilder.GetBankAccount();
    }
}
