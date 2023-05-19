using adapter;

ThirdPartyBankAccount thirdPartyBankAccount = new ThirdPartyBankAccount()
{
    AccountNumber = "123456789",
    Balance = 1000.0
};

IBankAccount bankAccount = new BankAccountAdapter(thirdPartyBankAccount);

// Используем объект bankAccount в нашей банковской системе