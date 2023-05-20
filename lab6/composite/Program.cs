using composite;

var account1 = new BankAccount("123456789", 1000);
var account2 = new BankAccount("987654321", 2000);

// Создание композитного узла (группы счетов)
var accountGroup = new BankAccountGroup("Group 1");
accountGroup.AddAccount(account1);
accountGroup.AddAccount(account2);

// Получение баланса для отдельного счета
var balance1 = account1.GetBalance();
Console.WriteLine("Баланс счета 1: " + balance1);

// Получение баланса для отдельного счета
var balance2 = account2.GetBalance();
Console.WriteLine("Баланс счета 2: " + balance2);

// Получение баланса для группы счетов
var groupBalance = accountGroup.GetBalance();
Console.WriteLine("Общий баланс группы счетов: " + groupBalance);