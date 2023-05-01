# Стратегия (Strategy)
Реализация на языке C# в рамках Лабораторной работы №3

## Структура
* [IInterestRateStrategy](IInterestRateStrategy.cs) - интерфейс стратегии
* [LowInterestRateStrategy](LowInterestRateStrategy.cs) - стратегия расчета низкой процентной ставки
* [HighInterestRateStrategy](HighInterestRateStrategy.cs) - стратегия расчета высокой процентной ставки
* [SavingsAccount](SavingsAccount.cs) - контекст, который используется клиентом для реализации стратегии
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](strategy.puml)
```
@startuml
interface IInterestRateStrategy {
    +CalculateInterest(decimal balance)
}

class LowInterestRateStrategy {
    +CalculateInterest(decimal balance)
}

class HighInterestRateStrategy {
    +CalculateInterest(decimal balance)
}

class SavingsAccount {
    -_interestRateStrategy: IInterestRateStrategy
    +SetPaymentStrategy(IInterestRateStrategy interestRateStrategy)
    +CalculateInterest(decimal balance)
}

SavingsAccount o-- IInterestRateStrategy
IInterestRateStrategy <|.. LowInterestRateStrategy
IInterestRateStrategy <|.. HighInterestRateStrategy

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab3/img/strat-uml.png)