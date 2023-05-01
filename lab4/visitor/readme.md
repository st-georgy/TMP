# Посетитель (Visitor)
Реализация на языке C# в рамках Лабораторной работы №4

## Структура
* [BankAccount](BankAccount.cs) - класс банковского счета
* [CreditAccount](CreditAccount.cs) - класс кредитного счета
* [SavingsAccount](SavingsAccount.cs) - класс сберегательного счета
* [IBankAccountVisitor](IBankAccountVisitor.cs) - интерфейс посетителя
* [BankReport](BankReport.cs) - класс банковского счета, реализующего интерфейс посетителя
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](visitor.puml)
```
@startuml
interface IBankAccountVisitor {
    + Visit(CreditAccount account)
    + Visit(SavingsAccount account)
}

abstract class BankAccount {
    + AccountNumber : string
    + Balance : decimal
    + Accept(visitor: IBankAccountVisitor) : void
}

class CreditAccount {
    + Accept(visitor: IBankAccountVisitor) : void
}

class SavingsAccount {
    + Accept(visitor: IBankAccountVisitor) : void
}

class BankReport {
    + Visit(CreditAccount account) : void
    + Visit(SavingsAccount account) : void
}

BankAccount <|-- CreditAccount 
BankAccount <|-- SavingsAccount

IBankAccountVisitor <|.. BankReport
@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab4/img/visit-uml.png)