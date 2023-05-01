namespace template
{
    // Класс платежа
    internal class Payment
    {
        public string ToAccount { get; set; }
        public string FromAccount { get; set; }
        public decimal Amount { get; set; }

        public Payment(string toAccount, decimal amount)
        {
            ToAccount = toAccount;
            Amount = amount;
        }

        public Payment(string toAccount, string fromAccount, decimal amount)
        {
            ToAccount = toAccount;
            FromAccount = fromAccount;
            Amount = amount;
        }
    }
}
