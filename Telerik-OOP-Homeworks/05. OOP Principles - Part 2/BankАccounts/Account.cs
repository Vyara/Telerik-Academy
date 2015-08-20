namespace BankАccounts
{
    using System;
    using System.Text;


    public abstract class Account
    {
        //fields
        private decimal balance;
        
        //constructors
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //properties
        public Customer Customer { get; private set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Account balance cannot be less than zero.");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate { get; private set; }

        //methods
        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }

        public override string ToString()
        {
            var account = new StringBuilder();
            account.AppendFormat("Customer Type: {0}", this.Customer.GetType().Name);
            account.AppendLine();
            account.AppendFormat("Customer Name: {0}", this.Customer.Name);
            account.AppendLine();
            account.AppendFormat("Balance: {0}", this.Balance);
            account.AppendLine();
            account.AppendFormat("Interest Rate: {0}", this.InterestRate);
            account.AppendLine();

            return account.ToString();

        }
    }
}
