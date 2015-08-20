//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


using System;



class BinaryShort
{
    static void Main()
    {
        string str;
        short number;

        //asks for user inputs
        do
        {
            Console.Write("Please enter an integer between {0} and {1}: ", short.MinValue, short.MaxValue);
            str = Console.ReadLine();

        } while (!short.TryParse(str, out number));

        long remainder;
        int posNumber = Math.Abs(number);
        string result = string.Empty;
        if (posNumber == 0)
        {
            result = "0";
        }
        while (posNumber > 0)
        {
            remainder = posNumber % 2;
            posNumber /= 2;
            result = remainder.ToString() + result;
        }

        if (number < 0)
        {
            result = result.PadLeft(16, '1');
        }

        else
        {
            result = result.PadLeft(16, '0');
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("the binary representation of the number {0} is: {1}", str, result.ToString());
    }
}

