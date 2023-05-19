using builder;

IBankAccountBuilder bankAccountBuilder = new BankAccountBuilder();
BankAccountDirector bankAccountDirector = new BankAccountDirector(bankAccountBuilder);

bankAccountDirector.CreateBankAccount("123456789", 1000, "John Smith", "Checking");
BankAccount bankAccount = bankAccountDirector.GetBankAccount();