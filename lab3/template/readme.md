# Шаблонный метод (Template Method)
Реализация на языке C# в рамках Лабораторной работы №3

## Структура
* [Payment](Payment.cs) - класс платежа
* [Account](Account.cs) - базовый класс Account
* [SavingsAccount](SavingsAccount) - класс сберегательного счета, наследует Account
* [CreditAccount](CreditAccount.cs) - класс кредитного счета, наследует Account
* [Program](Program.cs) - пример действия


## Диаграмма
[UML-диаграмма](template.puml)
```
@startuml
abstract class Account {
    -payments: Payment[]
    +ProcessPayments()
    +GetPayments()
    +CalculateFee()
    +TransferMoney()
    +WriteToLog()
    {abstract} +ProcessPayment(Payment payment)
}

class SavingsAccount {
    +ProcessPayment(Payment payment)
    +CalculateFee()
    +TransferMoney()
    +WriteToLog()
}

class CreditAccount {
    +ProcessPayment(Payment payment)
    +TransferMoney()
    +WriteToLog()
}

class Payment {
    -amount: decimal
    -fromAccount: string
    -toAccount: string
    +Payment(amount: decimal, fromAccount: string, toAccount: string)
    +Amount(): decimal
    +FromAccount(): string
    +ToAccount(): string
}

Account <|-- SavingsAccount
Account <|-- CreditAccount

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab3/img/templ-uml.png)