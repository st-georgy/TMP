namespace visitor
{
    // Интерфейс посетителя
    internal interface IBankAccountVisitor
    {
        void Visit(CreditAccount account);
        void Visit(SavingsAccount account);
    }
}
