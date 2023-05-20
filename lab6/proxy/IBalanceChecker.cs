namespace proxy
{
    public interface IBalanceChecker
    {
        decimal GetBalance(string accountNumber);
    }
}
