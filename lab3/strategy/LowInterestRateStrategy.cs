namespace strategy
{
    // Стратегия для расчета низкой процентной ставки
    internal class LowInterestRateStrategy : IInterestRateStrategy
    {
        public decimal CalculateInterest(decimal balance) =>
            balance * 0.01m;
    }
}
