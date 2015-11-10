namespace SortStudents
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using Wintellect.PowerCollections;

    public static class Tests
    {
       private static readonly SortedDictionary<Course, OrderedBag<Student>> Courses = new SortedDictionary<Course, OrderedBag<Student>>();

        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            ParseStudentsInput();
            PrintCourses();
        }

        private static void ParseStudentsInput()
        {
            using (var reader = new StreamReader("../../students.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var studentInfo = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    Courses.AddOrCreate(studentInfo[2], studentInfo[0], studentInfo[1]);
                }
            }
        }

        private static void AddOrCreate(this SortedDictionary<Course, OrderedBag<Student>> dictionary, string courseName, params string[] studentNames)
        {
            var course = new Course(courseName);
            var student = new Student(studentNames[0], studentNames[1]);

            if (!dictionary.ContainsKey(course))
            {
                dictionary[course] = new OrderedBag<Student>();
            }

            dictionary[course].Add(student);
        }

        private static void PrintCourses()
        {
            foreach (var course in Courses)
            {
                Console.Write(course.Key.ToString());

                foreach (var student in course.Value)
                {
                    Console.Write("{0}, ", student);
                }

                Console.WriteLine();
            }
        }
    }
}
