namespace proxy
{
    public class BalanceCheckerProxy : IBalanceChecker
    {
        private readonly IBalanceChecker balanceChecker;
        private Dictionary<string, decimal> balanceCache;

        public BalanceCheckerProxy(IBalanceChecker balanceChecker)
        {
            this.balanceChecker = balanceChecker;
            balanceCache = new Dictionary<string, decimal>();
        }

        public decimal GetBalance(string accountNumber)
        {
            // Проверка наличия кэша для баланса по заданному счету
            if (balanceCache.ContainsKey(accountNumber))
            {
                Console.WriteLine("Баланс получен из кэша.");
                return balanceCache[accountNumber];
            }
            else
            {
                decimal balance = balanceChecker.GetBalance(accountNumber);

                // Добавление баланса в кэш
                balanceCache.Add(accountNumber, balance);

                Console.WriteLine("Баланс получен из внешнего сервиса и добавлен в кэш.");
                return balance;
            }
        }
    }
}
