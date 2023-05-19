# Адаптер (Adapter)
Реализация на языке C# в рамках Лабораторной работы №5

## Структура
* [IBankAccount](IBankAccount.cs) - интерфейс банковского счета
* [ThirdPartyBankAccount](ThirdPartyBankAccount.cs) - "сторонний" класс, который предоставляет функциональность для работы с банковскими счетами
* [BankAccountAdapter](BankAccountAdapter.cs) - класс, который представляет адаптер между объектами ThirdPartyBankAccount и BankAccount
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](adapter.puml)
```
@startuml

interface IBankAccount {
    + GetAccountNumber(): string
    + GetBalance(): decimal
}

class ThirdPartyBankAccount {
    + AccountNumber: string
    + Balance: double
}

class BankAccountAdapter {
    - thirdPartyBankAccount: ThirdPartyBankAccount
    + BankAccountAdapter(thirdPartyBankAccount: ThirdPartyBankAccount)
    + GetAccountNumber(): string
    + GetBalance(): decimal
}

IBankAccount <|.. BankAccountAdapter
BankAccountAdapter --> ThirdPartyBankAccount

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab5/img/adapter-uml.png)