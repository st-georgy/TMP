using System.Collections;

namespace iterator
{
    internal class BankAccountCollection : IEnumerable<BankAccount>
    {
        private List<BankAccount> _accounts = new List<BankAccount>();

        public IEnumerator<BankAccount> GetEnumerator() =>
            _accounts.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void AddAccount(BankAccount account) =>
            _accounts.Add(account);
    }
}
