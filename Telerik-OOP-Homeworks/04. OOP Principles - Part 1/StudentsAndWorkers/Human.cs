namespace StudentsAndWorkers
{
    using System;
    using System.Text;

    public abstract class Human
    {
        //fields
        private string firstName;
        private string lastName;

        //constructors
        protected Human() { }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }


        //methods
        public override string ToString()
        {
            var human = new StringBuilder();
            human.AppendFormat("{0} {1}", this.FirstName, this.LastName);
            human.AppendLine();

            return human.ToString();
        }
    }
}
