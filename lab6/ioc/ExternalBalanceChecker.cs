namespace ioc
{
    public class ExternalBalanceChecker : IBalanceChecker
    {
        public decimal GetBalance(string accountNumber)
        {
            // Взаимодействие с внешним сервисом для получения баланса
            // В данном примере возвращается случайное значение
            Random random = new Random();
            return (decimal)random.NextDouble() * 10000;
        }
    }
}
