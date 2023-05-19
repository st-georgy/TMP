namespace mediator
{
    public interface IBankMediator
    {
        void SendTransfer(BankAccount sender, BankAccount receiver, decimal amount);
        void SendWithdrawal(BankAccount sender, decimal amount);
    }
}
