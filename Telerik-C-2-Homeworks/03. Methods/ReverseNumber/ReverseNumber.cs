//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	    output
//256	    652
//123.45	54.321

using System;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        string str;
        decimal number;

        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        //asks user to enter a decimal number
        do
        {
            Console.Write("Please enter a decimal number: ");
            str = Console.ReadLine();

        } while (!decimal.TryParse(str, out number));

        Console.WriteLine("-------------------------------------------");

        //uses ReverseGivenNumber() to reverse the given number
        decimal result = ReverseGivenNumber(number);

        //prints the result
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Number: {0}, Reversed: {1}", number, result);
    }

    //method that reverses the digits of given decimal number
    static decimal ReverseGivenNumber(decimal number)
    {
        string numberToString = number.ToString();
        string reversed = "";
        for (int i = 0; i < numberToString.Length; i++)
        {
            reversed += numberToString[numberToString.Length - 1 - i];
        }
        decimal reversedNumber = decimal.Parse(reversed);
        return reversedNumber;
    }
}
