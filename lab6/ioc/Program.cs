using ioc;

IBalanceChecker balanceChecker = new ExternalBalanceChecker();
BankClient bankClient = new BankClient(balanceChecker);

// Выполнение проверки баланса для определенного счета
string accountNumber = "123456789";
bool isBalancePositive = bankClient.CheckBalance(accountNumber);

// Дальнейшие действия в зависимости от результата проверки
if (isBalancePositive)
{
    // Выполнение действий для положительного баланса
}
else
{
    // Выполнение действий для отрицательного или нулевого баланса
}