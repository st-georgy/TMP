# Абстрактная Фабрика (Abstract Factory)
Реализация на языке C# в рамках Лабораторной работы №5

## Структура
* [BankFactory](abstract/BankFactory.cs) - абстрактная фабрика, которая будет создавать конкретные объекты
* [IBankAccount](abstract/IBankAccount.cs) - интерфейс банковского аккаунта
* [ICreditCard](abstract/ICreditCard.cs) - интерфейс кредитной карты 
* [ICreditProduct](abstract/ICreditProduct.cs) - интерфейс кредитного продукта
* [AlphaBankFactory](concrete/AlphaBankFactory.cs) - фабрика банка "Альфа"
* [AlphaBankAccount](concrete/AlphaBankAccount.cs) - банковский аккаунт банка "Альфа"
* [AlphaCreditCard](concrete/AlphaCreditCard.cs) - кредитная карта банка "Альфа"
* [AlphaCreditProduct](concrete/AlphaCreditProduct.cs) - кредитный продукт банка "Альфа"
* [BankClient](client/BankClient.cs) - клиентский класс, который использует абстрактную фабрику для создания конкретных объектов
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](abstract_factory.puml)
```
@startuml

interface IBankAccount {
    + Deposit(amount: decimal): void
    + Withdraw(amount: decimal): void
    + GetBalance(): decimal
}

interface ICreditCard {
    + MakePayment(amount: decimal): bool
    + GetBalance(): decimal
}

interface ICreditProduct {
    + GetInterestRate(): decimal
    + GetMonthlyPayment(principal: decimal, term: int): decimal
}

abstract class BankFactory {
    + CreateBankAccount(accountNumber: string, balance: decimal): IBankAccount
    + CreateCreditCard(cardNumber: string, balance: decimal): ICreditCard
    + CreateCreditProduct(principal: decimal, term: int): ICreditProduct
}

class AlphaBankAccount {
    - accountNumber: string
    - balance: decimal
    + Deposit(amount: decimal): void
    + Withdraw(amount: decimal): void
    + GetBalance(): decimal
}

class AlphaCreditCard {
    - cardNumber: string
    - balance: decimal
    + MakePayment(amount: decimal): bool
    + GetBalance(): decimal
}

class AlphaCreditProduct {
    - principal: decimal
    - term: int
    + GetInterestRate(): decimal
    + GetMonthlyPayment(principal: decimal, term: int): decimal
}

class AlphaBankFactory {
    + CreateBankAccount(accountNumber: string, balance: decimal): IBankAccount
    + CreateCreditCard(cardNumber: string, balance: decimal): ICreditCard
    + CreateCreditProduct(principal: decimal, term: int): ICreditProduct
}

class BankClient {
    - factory: BankFactory
    + OpenBankAccount(accountNumber: string, initialDeposit: decimal): IBankAccount
    + ApplyForCreditCard(cardNumber: string, creditLimit: decimal): ICreditCard
    + ApplyForCreditProduct(principal: decimal, term: int): ICreditProduct
}

BankFactory <|-- AlphaBankFactory
IBankAccount <|.. AlphaBankAccount
ICreditCard <|.. AlphaCreditCard
ICreditProduct <|.. AlphaCreditProduct
BankFactory <|-- AlphaBankFactory
BankClient --> BankFactory

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab5/img/absfact-uml.png)