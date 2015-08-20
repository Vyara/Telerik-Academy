namespace BankАccounts
{
    using System;
    using System.Text;

    public abstract class Customer
    {
        //fields
        private string name;

        //constructors
        public Customer() { }

        public Customer(string name)
        {
            this.Name = name;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        //methods
        public override string ToString()
        {
            var customer = new StringBuilder();
            customer.AppendFormat("{0}: {1}", this.GetType().Name, this.Name);
            customer.AppendLine();

            return customer.ToString();
        }

    }
}
