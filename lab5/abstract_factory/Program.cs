using abstract_factory.@abstract;
using abstract_factory.client;
using abstract_factory.concrete;

BankFactory alphaBankFactory = new AlphaBankFactory();
BankClient client = new BankClient(alphaBankFactory);

IBankAccount account = client.OpenBankAccount("123456789", 1000);
ICreditCard card = client.ApplyForCreditCard("1111222233334444", 5000);
ICreditProduct loan = client.ApplyForCreditProduct(10000, 12);