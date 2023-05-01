namespace visitor
{
    // Класс банковского отчета, реализующего интерфейс посетителя
    internal class BankReport : IBankAccountVisitor
    {
        public void Visit(CreditAccount account) =>
            Console.WriteLine($"Credit account {account.AccountNumber} has balance {account.Balance}");

        public void Visit(SavingsAccount account) =>
            Console.WriteLine($"Savings account {account.AccountNumber} has balance {account.Balance}");
    }
}
