//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.


using System;


class LeapYear
{
    static void Main()
    {
        string str;
        int year;

        //asks user to enter a year
        do
        {
            Console.Write("Please enter a year(yyyy): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out year));

        //checks if year is a leap one
        Console.WriteLine("------------------------------");
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is a leap year.", year);
        }

        else
        {
            Console.WriteLine("Year {0} is NOT a leap year.", year);
        }
    }

}

