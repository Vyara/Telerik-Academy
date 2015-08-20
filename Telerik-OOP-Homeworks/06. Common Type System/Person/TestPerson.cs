//Problem 4. Person class

//Create a class Person with two fields – name and age. Age can be left unspecified 
//(may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace Person
{
    using System;

    class TestPerson
    {
        static void Main()
        {
            //creating people
            var personWithAge = new Person("John Doe", 24);
            var personWithoutAge = new Person("Jane Doe", null);

            //printing people
            Console.WriteLine("People: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(personWithAge.ToString());
            Console.WriteLine(personWithoutAge.ToString());

        }
    }
}
