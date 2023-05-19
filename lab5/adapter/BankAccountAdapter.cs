
namespace adapter
{
    public class BankAccountAdapter : IBankAccount
    {
        private ThirdPartyBankAccount _thirdPartyBankAccount;

        public BankAccountAdapter(ThirdPartyBankAccount thirdPartyBankAccount) =>
            _thirdPartyBankAccount = thirdPartyBankAccount;

        public string GetAccountNumber() =>
            _thirdPartyBankAccount.AccountNumber;

        public decimal GetBalance() =>
            (decimal)_thirdPartyBankAccount.Balance;
    }
}
