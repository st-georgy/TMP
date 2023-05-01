namespace visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new BankAccount[]
            {
                new CreditAccount { AccountNumber = "111", Balance = 100 },
                new SavingsAccount { AccountNumber = "222", Balance = 200 },
                new CreditAccount { AccountNumber = "333", Balance = 300 }
            };

            IBankAccountVisitor bankReport = new BankReport();

            foreach (BankAccount account in accounts)
                account.Accept(bankReport);
        }
    }
}