# Компоновщик (Composite)
Реализация на языке C# в рамках Лабораторной работы №6

## Структура
* [Account](Account.cs) - абстрактный класс счета в банке
* [BankAccount](BankAccount.cs) - листовой узел, представляющий конкретный счет в банке
* [BankAccountGroup](BankAccountGroup.cs) - композитный узел, представляющий группу счетов
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](composite.puml)
```
@startuml

abstract class Account {
    - accountNumber: string
    + Account(accountNumber: string)
    + GetBalance(): decimal
}

class BankAccount {
    - balance: decimal
    + BankAccount(accountNumber: string, balance: decimal)
    + GetBalance(): decimal
}

class BankAccountGroup {
    - accounts: List<Account>
    + BankAccountGroup(accountNumber: string)
    + AddAccount(account: Account): void
    + GetBalance(): decimal
}

Account <|-- BankAccount
Account <|-- BankAccountGroup
BankAccountGroup o-- Account

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab6/img/composite-uml.png)