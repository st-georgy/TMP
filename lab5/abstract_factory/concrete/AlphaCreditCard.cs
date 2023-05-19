using abstract_factory.@abstract;

namespace abstract_factory.concrete
{
    internal class AlphaCreditCard : ICreditCard
    {
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }

        public AlphaCreditCard(string cardNumber, decimal balance)
        {
            CardNumber = cardNumber;
            Balance = balance;
        }

        public decimal GetBalance() => Balance;

        public bool MakePayment(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else return false;
        }
    }
}
