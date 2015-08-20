namespace StudentsAndWorkers
{
    using System;
    using System.Text;

    public class Student : Human
    {
        //fields
        private int grade;
        //constructors
        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }

        //properties
        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Student grade must be between 1 and 12.");
                }

                this.grade = value;
            }
        }

        //methods
        public override string ToString()
        {
            var student = new StringBuilder();
           
            student.AppendLine("Grade: " + this.Grade);
            
            return base.ToString() + student;
        }
    }
}
