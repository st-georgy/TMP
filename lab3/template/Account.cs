namespace template
{
    // Базовый класс Account
    internal abstract class Account
    {
        public void ProcessPayments()
        {
            var payments = GetPayments();

            foreach (var payment in payments) {
                decimal fee = CalculateFee(payment.Amount);
                TransferMoney(payment.ToAccount, payment.Amount - fee);
                WriteToLog(payment, fee);
            }
        }

        protected abstract Payment[] GetPayments();

        protected virtual decimal CalculateFee(decimal amount) =>
            amount * 0.01m;

        protected abstract void TransferMoney(string toAccount, decimal amount);

        protected virtual void WriteToLog(Payment payment, decimal fee) =>
            Console.WriteLine($"Processed payment for {payment.Amount}, fee: {fee}, to account: {payment.ToAccount}");
    }
}
