//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;
using System.Globalization;
using System.Linq;


class Workdays
{
    static void Main()
    {
        string input;

        //asks user for input
        Console.Write("Please enter a date between today and 31.12.2015(dd-mm-yyyy): ");
        input = Console.ReadLine();
        
        //splits user input and creates an array, then builds a new DateTime from its elements
        int[] formatInput = input.Split('-').Select(int.Parse).ToArray();
        DateTime date = new DateTime(formatInput[2], formatInput[1], formatInput[0]);
        
        //calculates result using NumberOfWorkDays()
        int result = NumberOfWorkDays(date);
        
        //prints the result
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("There are {0} working days between {1:dd/MM/yyyy} and {2:dd/MM/yyyy}", result, DateTime.Now, date);  

    }
    //method that calculates the number of workdays between today and given date
    static int NumberOfWorkDays(DateTime date)
    {
        DateTime today = DateTime.Now;
        DateTime[] officialHoliays = {new DateTime(2015, 1, 1),  new DateTime(2015, 3, 3), new DateTime(2015, 4, 10), 
                                      new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
                                      new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
                                      new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)};
        int workingDays = 0;
        if (today > date)
        {
            DateTime temp = today;
            date = temp;
            today = date;
        }

        while (today <= date)
        {
            if (!officialHoliays.Contains(today) && today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                workingDays++;
            }
            today = today.AddDays(1);
        }

        return workingDays;
    }


}

