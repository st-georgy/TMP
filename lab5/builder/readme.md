# Строитель (Builder)
Реализация на языке C# в рамках Лабораторной работы №5

## Структура
* [IBankAccountBuilder](IBankAccountBuilder.cs) - интерфейс строителя банковского аккаунта
* [BankAccount](BankAccount.cs) - класс банковского счета
* [BankAccountBuilder](BankAccountBuilder.cs) - класс строителя банковского аккаунта, который реализует интерфейс IBankAccountBuilder и поэтапно создает объекты BankAccount 
* [BankAccountDirector](BankAccountDirector.cs) - класс директора, который использует объекты строителя для создания BankAccount
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](builder.puml)
```
@startuml

class BankAccount {
    + AccountNumber: string
    + Balance: decimal
    + AccountHolder: string
    + AccountType: string
}

interface IBankAccountBuilder {
    + SetAccountNumber(accountNumber: string): void
    + SetBalance(balance: decimal): void
    + SetAccountHolder(accountHolder: string): void
    + SetAccountType(accountType: string): void
    + GetBankAccount(): BankAccount
}

class BankAccountBuilder {
    - bankAccount: BankAccount
    + SetAccountNumber(accountNumber: string): void
    + SetBalance(balance: decimal): void
    + SetAccountHolder(accountHolder: string): void
    + SetAccountType(accountType: string): void
    + GetBankAccount(): BankAccount
}

class BankAccountDirector {
    - bankAccountBuilder: IBankAccountBuilder
    + CreateBankAccount(accountNumber: string, balance: decimal, accountHolder: string, accountType: string): void
    + GetBankAccount(): BankAccount
}

BankAccountBuilder ..|> IBankAccountBuilder
BankAccountDirector--> IBankAccountBuilder
BankAccountDirector --> BankAccountBuilder
BankAccountBuilder --> BankAccount

@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab5/img/builder-uml.png)