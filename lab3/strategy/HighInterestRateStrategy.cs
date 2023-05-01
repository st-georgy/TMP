namespace strategy
{
    // Стратегия для расчета высокой процентной ставки
    internal class HighInterestRateStrategy : IInterestRateStrategy
    {
        public decimal CalculateInterest(decimal balance) =>
            balance * 0.02m;
    }
}
