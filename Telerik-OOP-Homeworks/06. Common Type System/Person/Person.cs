namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        //fields
        private string name;
        private int? age;

        //constructors
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
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

        public int? Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (this.Age < 0 || this.Age > 200)
                {
                    throw new ArgumentException("Age must be between 0 and 200.");
                }

                this.age = value;
            }
        }

        //methods
        public override string ToString()
        {
            var person = new StringBuilder();

            person.AppendLine("Name " + this.Name);

            if (this.Age == null)
            {
                person.AppendLine("Age: unspecified");
            }

            else
            {
                person.AppendLine("Age: " + this.Age);
            }

            return person.ToString();
        }
    }
}
