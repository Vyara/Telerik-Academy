namespace Student
{
    using System;
    using System.Collections.Generic;

    class TestStudent
    {
        static void Main()
        {
         //list of students
            var students = new List<Student>()
            {
                new Student("John", "Jack", "Doe", "014772265732657", "Magic Street 6", "0 555 555 555", "johndoe@gmail.com", 
                            "Freshman", Speciality.Computer_Science, University.MIT, Faculty.Technology),
                new Student("Jane", "Jones", "Doe", "927630586747", "Deep Forest 23", "0 888 888 888", "janedoe@yahoo.com", 
                            "Freshman", Speciality.Mathematics, University.CalTech, Faculty.Mathematics),
                new Student("Stephen", "William", "Hawking", "0275375309845", "New Road 17", "0 999 999 999", "hawking@gmail.com", 
                            "Freshman", Speciality.Physics, University.Cambridge, Faculty.Physics),
                new Student("Samantha", "Katherine", "Kent", "23472342637", "Bakerstreet 32", "0 666 666 666", "katkent@gmail.com", 
                            "Freshman", Speciality.Chemistry, University.MIT, Faculty.Chemistry)
            };

            //cloning first student
            var cloned = (Student)students[0].Clone();

            //comparing cloned student with first student and cloned with second student using Equals, ==
            var cloningOpeator = cloned == students[0];
            var differentStudentsComparison = students[1] == students[2];

            //comparing using CompareTo
            var clonedCompareTo = cloned.CompareTo(students[0]);
            var studentsCompareTo = students[1].CompareTo(students[2]);

            Console.WriteLine("List of Students: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Cloned Student 1: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(cloned.ToString());


            Console.WriteLine("Comparing cloned student to cloner student using == operator: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Does cloned Student == cloner Student? {0}", cloningOpeator ? "Yes." : "No.");

            Console.WriteLine();
            Console.WriteLine("Comparing  Student 1 to Student 2 using == operator: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Does Student 1 == Student 2? {0}", differentStudentsComparison ? "Yes." : "No.");

            Console.WriteLine();
            Console.WriteLine("Comparing cloned student to cloner student using CompareTo(): ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Does cloned Student == cloner Student? {0}", clonedCompareTo == 0 ? "Yes." : "No.");

            Console.WriteLine();
            Console.WriteLine("Comparing Student 1 to Student 2 using CompareTo(): ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Does cloned Student == cloner Student? {0}", studentsCompareTo == 0 ? "Yes." : "No.");
        }
    }
}
