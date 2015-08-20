//Problem 3. First before last

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.


using System;
using System.Collections.Generic;
using System.Linq;
using Student = StudentClass.Student;


public class FirstBeforeLast
{
    public static void Main()
    {
        //list with students
        var students = new Student[]
        {
            new Student("John", "Doe"),
            new Student("Jane", "Doe"),
            new Student("Alana", "Smith"),
            new Student("Brian", "Jones"),
            new Student("Zoe", "Ferguson"),
            new Student("Bob", "Bobson"),
            new Student("Kate", "Morris")
        };

        Console.WriteLine("List of students: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }

        var selectedStrudents = SortStudentsByName(students);
        Console.WriteLine();
        Console.WriteLine("List of students, whose first name is before their last name: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in selectedStrudents)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }

    private static IEnumerable<Student> SortStudentsByName(Student[] students)
    {
        var selectedStudents =
        from student in students
        where student.FirstName.CompareTo(student.LastName) < 0
        select student;

        return selectedStudents;
    }
}


