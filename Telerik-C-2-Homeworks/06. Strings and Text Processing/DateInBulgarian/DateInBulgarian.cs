//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Globalization;
using System.Threading;


class DateInBulgarian
{
    static void Main()
    {
        string date;
        DateTime formattedDate;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;
        
        //asks user for input
        Console.Write("Please enter a date in the format \"dd.MM.yyyy HH:mm:ss\": ");
        date = Console.ReadLine();
        formattedDate = DateTime.ParseExact(date, "d.M.yyyy H:m:s", bg);

        //adds hours and minutes
        formattedDate = formattedDate.AddHours(6).AddMinutes(30);

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(formattedDate.ToString("dd.MM.yyyy HH:mm:ss dddd"), bg);
    }
}

