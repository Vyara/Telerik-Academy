//Problem 1. School classes

//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. 
//Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class TestSchool
    {
        static void Main()
        {
            //list of students
            var students = new List<Student>()
            {
             new Student("John", "Doe", 23840, 24, "male"),
            new Student("Jane", "Doe", 34653, 21, "female"),
            new Student("Alana", "Smith", 762342),
            };

            //list of teachers
            var teachers = new List<Teacher>()
            {
             new Teacher("Brian", "Jones"),
            new Teacher("Zoe", "Ferguson"),
            new Teacher("Bob", "Bobson"),
            };

            //adding disciplines
            teachers[0].AddDiscipline(new Discipline("Physics", 3, 4));
            teachers[0].AddDiscipline(new Discipline("Mathematics", 4, 5));
            teachers[1].AddDiscipline(new Discipline("Chemistry", 12, 5));
            teachers[1].AddDiscipline(new Discipline("Literature", 8, 4));
            teachers[2].AddDiscipline(new Discipline("Music", 8, 4));

            //creating school with a class and adding teachers
            var school = new School();
            school.AddClass(new Class("12A", teachers[0], teachers[1], teachers[2]));

            Console.WriteLine("Students: ");

            Console.WriteLine(new string('-', 30));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Teachers: ");

            Console.WriteLine(new string('-', 30));

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }


            Console.WriteLine("School: ");

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(school);


        }
    }
}
