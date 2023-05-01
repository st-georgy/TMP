# Итератор (Iterator)
Реализация на языке C# в рамках Лабораторной работы №4

## Структура
* [BankAccount](BankAccount.cs) - класс банковского счета
* [BankAccountCollection](BankAccountCollection.cs) - коллекция счетов, реализует интерфейс IEnumerable\<BankAccount\>
* [Program](Program.cs) - пример действия

## Диаграмма
[UML-диаграмма](iterator.puml)
```
@startuml
interface IEnumerator<BankAccount> {
  + Current: BankAccount
  + MoveNext(): bool
  + Reset(): void
}

interface IEnumerable<BankAccount> {
  + GetEnumerator(): IEnumerator<BankAccount>
}

class BankAccounts {
  - accounts: List<BankAccount>
  + GetEnumerator(): IEnumerator<BankAccount>
  + AddAccount(account: BankAccount): void
}

class BankAccount {
  - accountNumber: string
  - balance: decimal
  + AccountNumber: string
  + Balance: decimal
}

BankAccounts -> IEnumerable
BankAccounts ..> BankAccount
BankAccount -up-|> IEnumerator
BankAccount ..> BankAccounts: contains
@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab4/img/iter-uml.png)