//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;



class DatesFromTextInCanada
{
    static void Main()
    {
        DateTime date;
        //asks user for input
        Console.Write("Please enter text(words separated by space): ");
        string input = Console.ReadLine();
        CultureInfo Canada = new CultureInfo("en-CA");
        //splits user input
        string[] splittedText = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        //looks for an exact match to DD.MM.YYYY
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < splittedText.Length; i++)
        {
            if (DateTime.TryParseExact(splittedText[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {

                Console.WriteLine(date.ToString(Canada.DateTimeFormat.ShortDatePattern));
            }
        }
    }
}

