namespace visitor
{
    // Класс кредитного счета
    internal class CreditAccount : BankAccount
    {
        public override void Accept(IBankAccountVisitor visitor) =>
            visitor.Visit(this);
    }
}
