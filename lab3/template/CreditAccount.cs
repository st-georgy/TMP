namespace template
{
    // Класс кредитного счета, который наследует базовый абстрактный класс Account
    internal class CreditAccount : Account
    {
        protected override Payment[] GetPayments() =>
            new Payment[]
            {
                new Payment("12345", 100m),
                new Payment("54321", 200m)
            };

        protected override decimal CalculateFee(decimal amount) =>
            amount * 0.02m;

        protected override void TransferMoney(string toAccount, decimal amount) =>
            Console.WriteLine($"Transferred {amount} from account to {toAccount}");

        protected override void WriteToLog(Payment payment, decimal fee) =>
            Console.WriteLine($"Processed payment for {payment.Amount}, fee: {fee}, from account: {payment.FromAccount}");
    }
}
