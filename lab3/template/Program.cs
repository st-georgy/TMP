namespace template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account savingsAccount = new SavingsAccount();
            Account creditAccount = new CreditAccount();

            Console.WriteLine("Processing payments for savings account:");
            savingsAccount.ProcessPayments();

            Console.WriteLine();

            Console.WriteLine("Processing payments for credit account:");
            creditAccount.ProcessPayments();
        }
    }
}