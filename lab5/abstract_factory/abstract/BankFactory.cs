namespace abstract_factory.@abstract
{
    public abstract class BankFactory
    {
        public abstract IBankAccount CreateBankAccount(string accountNumber, decimal balance);
        public abstract ICreditCard CreateCreditCard(string cardNumber, decimal balance);
        public abstract ICreditProduct CreateCreditProduct(decimal principal, int term);
    }
}
