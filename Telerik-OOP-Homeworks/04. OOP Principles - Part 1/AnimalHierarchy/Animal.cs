namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Animal : ISound
    {
        //fields
        private string name;
        private int age;
        private string sex;

        //constructors
        protected Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        //properties
        protected string Name
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

        protected int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be a negative number.");
                }

                this.age = value;
            }
        }

        protected string Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Gender can be either male or female.");
                }

                this.sex = value;
            }
        }

        //methods
        public static double AverageAge(IEnumerable<Animal> animals)
        {
            double average = animals.Average(x => x.Age);
            return average;
        }

        public static void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            var animal = new StringBuilder();
            animal.AppendFormat("Animal: {0}", this.GetType().Name);
            animal.AppendLine();
            animal.AppendFormat("Name: {0}", this.Name);
            animal.AppendLine();
            animal.AppendFormat("Gender: {0}", this.Sex);
            animal.AppendLine();
            animal.AppendFormat("Age: {0}", this.age);

            return animal.ToString();
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(this.Name + "made a sound.");
        }
    }
}
