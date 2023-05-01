namespace iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new BankAccountCollection();

            collection.AddAccount(new BankAccount { AccountNumber = "111", Balance = 100 });
            collection.AddAccount(new BankAccount { AccountNumber = "222", Balance = 200 });
            collection.AddAccount(new BankAccount { AccountNumber = "333", Balance = 300 });

            foreach (var account in collection)
                Console.WriteLine($"Account number: {account.AccountNumber}, Balance: {account.Balance}");
        }
    }
}