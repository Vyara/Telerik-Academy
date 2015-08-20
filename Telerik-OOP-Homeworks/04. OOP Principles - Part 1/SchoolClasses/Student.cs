namespace SchoolClasses
{
    using System;
    using System.Text;

    public class Student : Person
    {
        //fields
        private int classNumber;

        //constructors
        public Student(string firstName, string lastName, int classNumber)
            :base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string firstName, string lastName, int classNumber, int age)
            :this(firstName, lastName, classNumber)
        {
            this.Age = age;
        }

        public Student(string firstName, string lastName, int classNumber, int age, string gender)
            :this(firstName, lastName, classNumber, age)
        {
            this.Gender = gender;
        }

        //properties
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The unique class number must be larger than 0.");
                }

                this.classNumber = value;
            }
        }

        //methods

        public override string ToString()
        {
            var student = new StringBuilder();
            student.AppendFormat("Class number: {0}", this.ClassNumber);
            student.AppendLine();

            return base.ToString() + student.ToString();
        }
    }
}
