# Посредник (Mediator)
Реализация на языке C# в рамках Лабораторной работы №5

## Структура
* [BankAccount](BankAccount.cs) - класс банковского счета
* [IBankMediator](IBankMediator.cs) - интерфейс посредника, который определяет методы взаимодействия между объектами
* [BankMediator](BankMediator.cs) - класс посредника, реализует интерфейс
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](mediator.puml)
```
@startuml

interface IBankMediator {
    + SendTransfer(sender: BankAccount, receiver: BankAccount, amount: decimal)
    + SendWithdrawal(sender: BankAccount, amount: decimal)
}

class BankMediator {
    + SendTransfer(sender: BankAccount, receiver: BankAccount, amount: decimal)
    + SendWithdrawal(sender: BankAccount, amount: decimal)
}

class BankAccount {
    - accountNumber: string
    - balance: decimal
    - accountHolder: string
    - accountType: string
    - bankMediator: IBankMediator
    + BankAccount(accountNumber: string, balance: decimal, accountHolder: string, accountType: string, bankMediator: IBankMediator)
    + Withdraw(amount: decimal): bool
    + Transfer(receiver: BankAccount, amount: decimal): bool
    + Deposit(amount: decimal)
    + GetAccountNumber(): string
    + GetBalance(): decimal
    + GetAccountHolder(): string
    + GetAccountType(): string
}

IBankMediator <|.. BankMediator
BankMediator ..> BankAccount

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab5/img/mediator-uml.png)