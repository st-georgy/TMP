namespace visitor
{
    // Абстрактный класс аккаунта
    internal abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Метод принятия посетителя
        public abstract void Accept(IBankAccountVisitor visitor);
    }
}
