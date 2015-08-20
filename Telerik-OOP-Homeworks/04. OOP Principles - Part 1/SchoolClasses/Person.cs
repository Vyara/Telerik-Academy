namespace SchoolClasses
{
    using System;
    using System.Text;

    public abstract class Person
    {
        //fields
        private string firstName;
        private string lastName;
        private int? age;
        private string gender;

        //constructors
        protected Person() 
        { 
        }

        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected Person(string firstName, string lastName, int age)
            :this(firstName, lastName)
        {
            this.Age = age;
        }

        protected Person(string firstName, string lastName, int age, string gender)
            :this(firstName, lastName, age)
        {
            this.Gender = gender;
        }

        //properties
        protected string FirstName
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

        protected string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        protected int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Age must be between 0 and 200.");
                }

                this.age = value;
            }
        }

        protected string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Gender must be male or female.");
                }

                this.gender = value;

            }
        }
        //methods
        public override string ToString()
        {
            var person = new StringBuilder();
            person.AppendFormat("{0} {1}", this.FirstName, this.LastName);
            person.AppendLine();

            if (this.Age != null)
            {
                person.AppendLine("Age: " + this.Age);
            }

            if (this.Gender != null)
            {
                person.AppendLine("Gender: " + this.Gender);

            }

            return person.ToString();
        }
    }
}