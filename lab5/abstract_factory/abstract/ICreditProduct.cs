namespace abstract_factory.@abstract
{
    public interface ICreditProduct
    {
        decimal GetInterestRate();
        decimal GetMonthlyPayment(decimal principal, int term);
    }
}
