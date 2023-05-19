using mediator;

IBankMediator bankMediator = new BankMediator();

BankAccount senderAccount = new BankAccount("123456789", 1000.0m, "John Doe", "checking", bankMediator);
BankAccount receiverAccount = new BankAccount("987654321", 0.0m, "Jane Smith", "savings", bankMediator);

// Перевод средств со счета отправителя на счет получателя
senderAccount.Transfer(receiverAccount, 500.0m);

// Снятие денег
senderAccount.Withdraw(200.0m);