namespace ioc
{
    public interface IBalanceChecker
    {
        decimal GetBalance(string accountNumber);
    }
}
