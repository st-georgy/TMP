using abstract_factory.@abstract;

namespace abstract_factory.client
{
    public class BankClient
    {
        private BankFactory _factory;

        public BankClient(BankFactory factory) =>
            _factory = factory;

        public IBankAccount OpenBankAccount(string accountNumber, decimal initialDeposit) =>
            _factory.CreateBankAccount(accountNumber, initialDeposit);

        public ICreditCard ApplyForCreditCard(string cardNumber, decimal creditLimit) =>
            _factory.CreateCreditCard(cardNumber, creditLimit);

        public ICreditProduct ApplyForCreditProduct(decimal principal, int term) =>
            _factory.CreateCreditProduct(principal, term);
    }
}
