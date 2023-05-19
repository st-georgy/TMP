namespace mediator
{
    public class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;
        private string _accountHolder;
        private string _accountType;
        private IBankMediator _bankMediator;

        public BankAccount(string accountNumber, decimal balance, string accountHolder, string accountType, IBankMediator bankMediator)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _accountHolder = accountHolder;
            _accountType = accountType;
            _bankMediator = bankMediator;
        }

        public bool Withdraw(decimal amount)
        {
            bool success = false;
            if (_balance >= amount)
            {
                _balance -= amount;
                _bankMediator.SendWithdrawal(this, amount);
                success = true;
            }
            return success;
        }

        public bool Transfer(BankAccount receiver, decimal amount)
        {
            bool success = false;
            if (_balance >= amount)
            {
                _balance -= amount;
                _bankMediator.SendTransfer(this, receiver, amount);
                success = true;
            }
            return success;
        }

        public void Deposit(decimal amount) =>
            _balance += amount;

        public string GetAccountNumber() =>
            _accountNumber;

        public decimal GetBalance() =>
            _balance;

        public string GetAccountHolder() =>
            _accountHolder;

        public string GetAccountType() =>
            _accountType;
    }
}
