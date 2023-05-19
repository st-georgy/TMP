namespace abstract_factory.@abstract
{
    public interface ICreditCard
    {
        bool MakePayment(decimal amount);
        decimal GetBalance();
    }
}
