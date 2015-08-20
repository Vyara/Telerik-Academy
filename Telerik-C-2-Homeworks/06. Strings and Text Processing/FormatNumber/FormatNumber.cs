//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;


class FormatNumber
{
    static void Main()
    {
        long number;
        string str;

        //asks user for input
        do
        {
            Console.Write("Please enter a number: ");
            str = Console.ReadLine();
            //checks if number is decimal and if number is > 0
        } while (!long.TryParse(str, out number));

        //prints the results
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Decimal: {0}", number.ToString("D").PadRight(15));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Hexadecimal: {0}", number.ToString("X").PadRight(15));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Percentage: {0}", number.ToString("P").PadRight(15));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Scientific notation: {0}", number.ToString("E").PadRight(15));
    }
}

