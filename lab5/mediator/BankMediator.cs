namespace mediator
{
    public class BankMediator : IBankMediator
    {
        public void SendTransfer(BankAccount sender, BankAccount receiver, decimal amount)
        {
            if (sender.Withdraw(amount))
                receiver.Deposit(amount);
        }

        public void SendWithdrawal(BankAccount sender, decimal amount) =>
            sender.Withdraw(amount);
    }
}
