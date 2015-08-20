//Problem 5. Order students

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student = StudentClass.Student;


class OrderStudents
{
    static void Main()
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

        //sorting with OrderBy() and ThenBy()
        var lambdaSort = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
        
        Console.WriteLine("Students sorted with lambda expressions: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in lambdaSort)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }

        //sorting with LINQ
        var linqSort =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;

        Console.WriteLine();
        Console.WriteLine("Students sorted with LINQ: ");
        Console.WriteLine(new string('-', 30));
        foreach (var student in linqSort)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }

    }
}

