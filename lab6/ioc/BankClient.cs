namespace ioc
{
    public class BankClient
    {
        private readonly IBalanceChecker balanceChecker;

        public BankClient(IBalanceChecker balanceChecker) =>
            this.balanceChecker = balanceChecker;

        public bool CheckBalance(string accountNumber)
        {
            decimal balance = balanceChecker.GetBalance(accountNumber);

            if (balance > 0)
            {
                Console.WriteLine("Баланс положительный.");
                // Выполнение дополнительных действий для положительного баланса
                return true;
            }
            else
            {
                Console.WriteLine("Баланс отрицательный или равен нулю.");
                // Выполнение дополнительных действий для отрицательного или нулевого баланса
                return false;
            }
        }
    }
}
