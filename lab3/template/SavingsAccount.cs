namespace template
{
    // Класс сберегательного счета, который наследует базовый абстрактный класс Account
    internal class SavingsAccount : Account
    {
        protected override Payment[] GetPayments() =>
            new Payment[]
            {
                new Payment("12345", 100m),
                new Payment("54321", 200m)
            };

        protected override void TransferMoney(string toAccount, decimal amount) =>
            Console.WriteLine($"Transferred {amount} to account {toAccount}");
    }
}
