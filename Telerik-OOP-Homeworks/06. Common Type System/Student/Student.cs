//Problem 1. Student class

//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//Problem 2. IClonable

//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

//Problem 3. IComparable

//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number 
//(as second criteria, in increasing order).

namespace Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        //fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;

        //constructors
        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, 
            string mobilePhone, string email, string course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
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

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty.");
                }

                this.middleName = value;
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
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SSN cannot be null or empty.");
                }

                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address cannot be null or empty.");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be null or empty.");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course cannot be null or empty.");
                }

                this.course = value;
            }
        }

        public Speciality Speciality { get; private set; }

        public University University { get;  private set; }

        public Faculty Faculty { get; private set; }


        //methods
        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator != (Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null || !Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            var student = new StringBuilder();
            student.AppendFormat("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            student.AppendLine();
            student.AppendLine("SSN: " + this.SSN);
            student.AppendLine("Address: " + this.PermanentAddress);
            student.AppendLine("Phone: " + this.MobilePhone);
            student.AppendLine("E-mail: " + this.Email);
            student.AppendLine("Course: " + this.Course);
            student.AppendLine("Speciality: " + this.Speciality);
            student.AppendLine("University: " + this.University);
            student.AppendLine("Faculty: " + this.Faculty);

            return student.ToString();
        }

        public override int GetHashCode()
        {
            //will implement it with 2 prime numbers instead of using XOR
            int hash = 17;
            hash = hash * 23 + this.SSN.GetHashCode();
            hash = hash * 23 + this.MobilePhone.GetHashCode();
            hash = hash * 23 + this.FirstName.GetHashCode();
            return hash;
        }

        public object Clone()
        {
            var clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, 
            this.MobilePhone,  this.Email, this.Course, this.Speciality, this.University, this.Faculty);

            return clonedStudent;
        }


        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            return this.SSN.CompareTo(other.SSN);
        }
    }
}
