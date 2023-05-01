namespace strategy
{
    // Интерфейс стратегии - определяет метод, который должен быть реализован всеми стратегиями
    internal interface IInterestRateStrategy
    {
        decimal CalculateInterest(decimal balance);
    }
}
