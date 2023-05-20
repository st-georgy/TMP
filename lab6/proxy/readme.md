# Заместитель (Proxy)
Реализация на языке C# в рамках Лабораторной работы №6

## Структура
* [IBalanceChecker](IBalanceChecker.cs) - интерфейс для проверки баланса на счете
* [ExternalBalanceChecker](ExternalBalanceChecker.cs) - класс, реализующий проверку баланса на счете
* [BalanceCheckerProxy](BalanceCheckerProxy.cs) - класс заместителя для проверки баланса
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](proxy.puml)
```
@startuml

interface IBalanceChecker {
    + GetBalance(accountNumber: string): decimal
}

class ExternalBalanceChecker {
    + GetBalance(accountNumber: string): decimal
}

class BalanceCheckerProxy {
    - balanceChecker: IBalanceChecker
    - balanceCache: Dictionary<string, decimal>
    + BalanceCheckerProxy(balanceChecker: IBalanceChecker)
    + GetBalance(accountNumber: string): decimal
}

IBalanceChecker <|.. ExternalBalanceChecker
IBalanceChecker <|.. BalanceCheckerProxy
BalanceCheckerProxy o-- IBalanceChecker

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab6/img/proxy-uml.png)