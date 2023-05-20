using proxy;

// Создание экземпляра класса заместителя с передачей реального объекта в конструктор
IBalanceChecker balanceChecker = new ExternalBalanceChecker();
IBalanceChecker proxy = new BalanceCheckerProxy(balanceChecker);

// Выполнение проверки баланса для определенного счета
string accountNumber = "123456789";
decimal balance = proxy.GetBalance(accountNumber);

Console.WriteLine("Баланс на счете: " + balance);