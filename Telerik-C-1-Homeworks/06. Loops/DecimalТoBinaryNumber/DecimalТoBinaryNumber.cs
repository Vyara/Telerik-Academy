//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	    binary
//0	            0
//3	            11
//43691	        1010101010101011
//236476736	    1110000110000101100101000000

using System;



class DecimalТoBinaryNumber
{
    static void Main()
    {
        string str;
        long number;

        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!long.TryParse(str, out number) || number < 0);

        long remainder;
        string result = string.Empty;
        if (number == 0)
        {
            result = "0";
        }
        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            result = remainder.ToString() + result;
        }

        Console.WriteLine("the binary form of the number {0} is: {1}", str, result.ToString());
    }
}

