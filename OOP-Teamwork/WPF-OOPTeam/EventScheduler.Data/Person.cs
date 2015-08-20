namespace EventScheduler.Data
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    [Serializable]
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName,int age, Gender sex = Gender.NotSpecified)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = sex;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Name length must be greater than 2.");
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
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Name length must be greater than 2.");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            protected set
            {
                if (value<15 || value>50)
                {
                    throw new Exception("Age must be between 15 and 50.");
                }
                this.age = value;
            }
        }

        public Gender Gender { get; private set; }
      
    }
}
