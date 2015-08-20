
namespace StudentTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentClass;

    class StudentTests
    {
        static void Main()
        {
            //lists of students and groups
            var students = new List<Student>()
            {

            new Student("John", "Doe", "23840673", "029623625", "john@abv.bg", 3),
            new Student("Jane", "Doe", "3465306", "555555555", "jane@yahoo.com", 2),
            new Student("Alana", "Smith", "762342", "0899666666", "alana@hotmail.com", 4),
            new Student("Brian", "Jones", "2956237", "0999999999", "brian_j@abv.bg", 1),
            new Student("Zoe", "Ferguson", "3743655", "0288888888", "zoef@abv.bg", 2),
            new Student("Bob", "Bobson", "85730665", "088887777", "bobby@yahoo.de", 4),
            new Student("Kate", "Morris", "927456347", "027777775", "katem@gmail.com", 2)

            };

            var studentsWithGroups = new List<Student>()
            {

            new Student("John", "Doe", "23840673", "029623625", "john@abv.bg", new Group(3, "Literature")),
            new Student("Jane", "Doe", "3465306", "555555555", "jane@yahoo.com", new Group(2, "Physics")),
            new Student("Alana", "Smith", "762342", "0899666666", "alana@hotmail.com", new Group(4, "Mathematics")),
            new Student("Brian", "Jones", "2956237", "0999999999", "brian_j@abv.bg", new Group(1, "Chemistry")),
            new Student("Zoe", "Ferguson", "3743655", "0288888888", "zoef@abv.bg", new Group(2, "Physics")),
            new Student("Bob", "Bobson", "85730665", "088887777", "bobby@yahoo.de", new Group(4, "Mathematics")),
            new Student("Kate", "Morris", "927456347", "027777775", "katem@gmail.com", new Group(2, "Physics"))

            };

            var groups = new List<Group>()
            {
                new Group(1, "Chemistry"),
                new Group(2, "Physics"),
                new Group(3, "Literature"),
                new Group(4, "Mathematics")
            };

            //adding marks
            students[0].AddMarks(new int[] { 2, 3, 5, 6 });
            students[1].AddMarks(new int[] { 2, 2, 5, 4 });
            students[2].AddMarks(new int[] { 3, 3, 6, 6 });
            students[3].AddMarks(new int[] { 2, 3, 5, 2 });
            students[4].AddMarks(new int[] { 4, 4, 5 });
            students[5].AddMarks(new int[] { 2, 3 });

            //Problem 9. Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            var secondGroupStudents =
            from student in students
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;


            Console.WriteLine("Students from second group(LINQ): ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in secondGroupStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.
            var newSecondGroupStudents = students
                                         .Where(s => s.GroupNumber == 2)
                                         .OrderBy(s => s.FirstName);

            Console.WriteLine();
            Console.WriteLine("Students from second group(extension methods): ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in newSecondGroupStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }


            // Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            var studentsWithAbVEmail =
                from student in students
                where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                select student;

            Console.WriteLine();
            Console.WriteLine("Students with an email in abv.bg: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in studentsWithAbVEmail)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.
            var studentswithSofiaPhone =
                from student in students
                where student.Phone.StartsWith("02")
                select student;

            Console.WriteLine();
            Console.WriteLine("Students with a Sofia phone number: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in studentswithSofiaPhone)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.
            var excellentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = String.Join(", ", student.Marks) };

            Console.WriteLine();
            Console.WriteLine("Students with at least one 6 grade: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FullName + " " + student.Marks);
            }

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            var studentsWithTwoGrades = students
                                        .Where(s => s.Marks.Count(x => Math.Abs(x - 2) < 0.4) == 2)
                                        .Select(s => s.FirstName + " " + s.LastName + " " + String.Join(", ", s.Marks));

            Console.WriteLine();
            Console.WriteLine("Students with exatly two marks \"2\": ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in studentsWithTwoGrades)
            {
                Console.WriteLine(student);
            }

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentsIn2006 = students.Where(s => s.FacultyNumber[4] == '0' && s.FacultyNumber[5] == '6');

            Console.WriteLine();
            Console.WriteLine("Students that enrolled in 2006: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in studentsIn2006)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 16.* Groups
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Mathematics" department.
            //Use the Join operator.
            var mathStudents =
                from student in students
                join grp in groups on student.GroupNumber equals grp.GroupNumber
                where grp.DepartmentName == "Mathematics"
                select student;

            Console.WriteLine();
            Console.WriteLine("Students in Math Group: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in mathStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.
            var groupedStudentsLINQ =
                from student in studentsWithGroups
                orderby student.Group.GroupNumber
                select student;

            Console.WriteLine();
            Console.WriteLine("Students ordered by Groups(LINQ): ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in groupedStudentsLINQ)
            {
                Console.WriteLine("{0}. {1}: {2} {3}", student.Group.GroupNumber, student.Group.DepartmentName, student.FirstName, student.LastName);
            }

            //Problem 19. Grouped by GroupName extensions
            //Rewrite the previous using extension methods.
            var groupedStudentsExt = studentsWithGroups.OrderBy(s => s.Group.GroupNumber);

            Console.WriteLine();
            Console.WriteLine("Students ordered by Groups(extention methods): ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in groupedStudentsExt)
            {
                Console.WriteLine("{0}. {1}: {2} {3}", student.Group.GroupNumber, student.Group.DepartmentName, student.FirstName, student.LastName);
            }
        }
    }
}