//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        //fields
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phone;
        private string email;
        private readonly List<int> marks;
        private int groupNumber;

        //constructors
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = new List<int>();
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }

        public Student(string firstName, string lastName, string facultyNumber, string phone, string email, int groupNumber)
            : this(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.email = email;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, string facultyNumber, string phone, string email, Group group)
            : this(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.email = email;
            this.Group = group;

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be an empty string");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be an empty string");
                }

                this.lastName = value;
            }
        }
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty number cannot be empty.");
                }

                this.facultyNumber = value;
            }

        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number cannot be empty.");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be an empty string.");
                }
                if (!Regex.IsMatch(value, @"(\w+@\w+.\w+)"))
                {
                    throw new ApplicationException("Email must be valid.");
                }

                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Group number must be larger than zero.");
                }

                this.groupNumber = value;
            }
        }
        public List<int> Marks { get; set; }

        public Group Group { get; set; }

        public int Age { get; set; }


        //methods
        public void AddMark(int mark)
        {
            if (mark < 2 || mark > 6)
            {
                throw new ArgumentException("Marks must have a value between 2 and 6.");
            }

            this.Marks.Add(mark);
        }

        public void RemoveMark(int mark)
        {
            if (!this.Marks.Contains(mark))
            {
                throw new ArgumentException("Student doesn't have such mark.");
            }

            this.Marks.Remove(mark);
        }

        public void AddMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                if (mark < 2 || mark > 6)
                {
                    throw new ArgumentException("Marks must have a value between 2 and 6.");
                }

                this.Marks.Add(mark);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
