namespace strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var savingsAccount = new SavingsAccount(new LowInterestRateStrategy());

            var balance = 1250m;
            var interest = savingsAccount.CalculateInterest(balance);
            Console.WriteLine($"Balance: {balance}, Interest rate: {interest}");

            savingsAccount.SetInterestRateStrategy(new HighInterestRateStrategy());
            interest = savingsAccount.CalculateInterest(balance);
            Console.WriteLine($"Balance: {balance}, Interest rate: {interest}");
        }
    }
}