//Problem 4. Age range

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


using System;
using System.Linq;
using Student = StudentClass.Student;

class AgeRange
{
    static void Main()
    {
        //list with students
        var students = new Student[]
        {
            new Student("John", "Doe", 18),
            new Student("Jane", "Doe", 23),
            new Student("Alana", "Smith", 54),
            new Student("Brian", "Jones", 28),
            new Student("Zoe", "Ferguson", 33),
            new Student("Bob", "Bobson", 26),
            new Student("Kate", "Morris", 21)
        };

        var sortedStudents =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;


        Console.WriteLine("List of students: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in students)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
        }

        Console.WriteLine();
        Console.WriteLine("List of students with ages between 18 and 24: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
        }

    }
}

