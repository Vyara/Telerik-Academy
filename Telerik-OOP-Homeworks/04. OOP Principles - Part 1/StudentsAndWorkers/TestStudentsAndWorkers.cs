//Problem 2. Students and workers

//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestStudentsAndWorkers
    {
        static void Main()
        {
            //list of students
            var students = new List<Student>()
            {

            new Student("John", "Doe", 1),
            new Student("Jane", "Doe", 5),
            new Student("Alana", "Smith", 11),
            new Student("Brian", "Jones", 9),
            new Student("Zoe", "Ferguson", 12),
            new Student("Bob", "Bobson", 6),
            new Student("Kate", "Morris", 4),
            new Student("Cameron", "Samson", 4),
            new Student("Yuki", "Hamada", 4),
            new Student("Sam", "Christenson", 4)

            };

            //list of workers
            var workers = new List<Worker>()
            {

            new Worker("Isaac", "Newton", 153.4, 7),
            new Worker("Albert", "Einstein", 256.3, 9),
            new Worker("Paul", "Dirac", 303, 6),
            new Worker("Stephen", "Hawking", 50.26, 3),
            new Worker("Niels", "Bohr", 345.12, 8),
            new Worker("Alan", "Turing", 234.1, 7),
            new Worker("Ada", "Lovelace", 166.5, 9),
            new Worker("Neil", "Tyson", 254.3, 6),
            new Worker("Artur", "Clarke", 453.3, 8),
            new Worker("Galileo", "Galilei", 86.3, 5)

            };

            //sorts students by grade
            var sortedByGrade = students.OrderBy(s => s.Grade);

            //sorts workers by money per hour in descending order
            var sortedByMoneyEarned = workers.OrderByDescending(w => w.MoneyPerHour());

            //merges lists
            var merged = new List<Human>();
            merged.AddRange(sortedByGrade);
            merged.AddRange(sortedByMoneyEarned);

            //sorts list by first name and last name
            var sortedList = merged.OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName);

            Console.WriteLine("Students: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Sorted by Grade: ");
            Console.WriteLine(new string('-', 30));
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Workers: ");
            Console.WriteLine(new string('-', 30));
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("Sorted by Money Earned Per Hour(descending): ");
            Console.WriteLine(new string('-', 30));
            foreach (var worker in sortedByMoneyEarned)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("Merged list: ");
            Console.WriteLine(new string('-', 30));
            foreach (var human in merged)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine("Sorted by first and last name: ");
            Console.WriteLine(new string('-', 30));
            foreach (var human in sortedList)
            {
                Console.WriteLine(human);
            }


        }

    }
}
