namespace visitor
{
    // Класс сберегательного счета
    internal class SavingsAccount : BankAccount
    {
        public override void Accept(IBankAccountVisitor visitor) =>
            visitor.Visit(this);
    }
}
