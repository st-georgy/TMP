namespace builder
{
    public interface IBankAccountBuilder
    {
        void SetAccountNumber(string accountNumber);
        void SetBalance(decimal balance);
        void SetAccountHolder(string accountHolder);
        void SetAccountType(string accountType);
        BankAccount GetBankAccount();
    }
}
