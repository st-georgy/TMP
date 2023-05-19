using abstract_factory.@abstract;

namespace abstract_factory.concrete
{
    public class AlphaBankFactory : BankFactory
    {
        public override IBankAccount CreateBankAccount(string accountNumber, decimal balance) =>
            new AlphaBankAccount(accountNumber, balance);
        public override ICreditCard CreateCreditCard(string cardNumber, decimal balance)
            => new AlphaCreditCard(cardNumber, balance);
        
        public override ICreditProduct CreateCreditProduct(decimal principal, int term)
            => new AlphaCreditProduct(principal, term);
        
    }
}
