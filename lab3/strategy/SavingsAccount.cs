namespace strategy
{
    // Контекст, который используется клиентов для выполнения стратегии
    internal class SavingsAccount
    {
        private IInterestRateStrategy _interestRateStrategy;

        public SavingsAccount(IInterestRateStrategy interestRateStrategy) =>
            _interestRateStrategy = interestRateStrategy;

        public decimal CalculateInterest(decimal balance) =>
            _interestRateStrategy.CalculateInterest(balance);

        public void SetInterestRateStrategy(IInterestRateStrategy interestRateStrategy) =>
            _interestRateStrategy = interestRateStrategy;
    }
}
