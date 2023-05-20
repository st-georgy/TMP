# Инверсия управления (Inversion of Control)
Реализация на языке C# в рамках Лабораторной работы №6

## Структура
* [IBalanceChecker](IBalanceChecker.cs) - интерфейс для проверки баланса на счете
* [ExternalBalanceChecker](ExternalBalanceChecker.cs) - класс, реализующий проверку баланса на счете
* [BankClient](BankClient.cs) - класс клиента банка
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](ioc.puml)
```
@startuml

interface IBalanceChecker {
    + GetBalance(accountNumber: string): decimal
}

class ExternalBalanceChecker {
    + GetBalance(accountNumber: string): decimal
}

class BankClient {
    - balanceChecker: IBalanceChecker
    + BankClient(balanceChecker: IBalanceChecker)
    + CheckBalance(accountNumber: string): bool
}

IBalanceChecker <|.. ExternalBalanceChecker
BankClient --> IBalanceChecker

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab6/img/ioc-uml.png)