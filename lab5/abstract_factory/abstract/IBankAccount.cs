namespace abstract_factory.@abstract
{
    public interface IBankAccount
    {
        void Deposit(decimal amount);
        bool Withdraw(decimal amount);
        decimal GetBalance();
    }
}
