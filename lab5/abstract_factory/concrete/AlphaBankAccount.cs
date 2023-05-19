using abstract_factory.@abstract;

namespace abstract_factory.concrete
{
    public class AlphaBankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountHolder { get; set; }
        public string AccountType { get; set; }

        public AlphaBankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount) =>
            Balance += amount;

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
                return false;
        }

        public decimal GetBalance() => Balance;
    }
}
