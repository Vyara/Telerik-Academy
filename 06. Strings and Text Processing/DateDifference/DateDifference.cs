//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days


using System;
using System.Globalization;



class DateDifference
{
    static void Main()
    {
        string firstDate;
        string secondDate;
        DateTime startDate;
        DateTime endDate;
        
        //asks user for input
        Console.Write("Please enter a date \"dd.MM.yyyy\": ");
        firstDate = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter a second date \"dd.MM.yyyy\": ");
        secondDate = Console.ReadLine();

        //parses input accordingly
        startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture); 

        //calculates result
        double result = Math.Abs((endDate - startDate).TotalDays);

        //prints result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("There are {0} days between {1} and {2}", result, firstDate, secondDate);
    }
}

