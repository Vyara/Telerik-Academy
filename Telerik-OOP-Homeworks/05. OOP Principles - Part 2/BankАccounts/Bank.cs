namespace BankАccounts
{
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        //fields

        //constructors
        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        //properties
        public List<Account> Accounts { get; set; }


        //methods
        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.Accounts.Remove(account);
        }

        public override string ToString()
        {
            var accounts = new StringBuilder();
            accounts.AppendLine("Bank accounts: ");

            var count = 1;
            foreach (var account in this.Accounts)
            {
                accounts.AppendFormat("Account{0}: ", count);
                accounts.AppendLine(new string('-', 30));
                accounts.AppendLine(account.ToString());
                count++;
            }

            return accounts.ToString();
        }
    }
}
