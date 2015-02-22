//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.


using System;



class DecimalToBinary
{
    static void Main()
    {
        string str;
        long number;

        do
        {
            Console.Write("Please enter a positve integer: ");
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
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("the binary form of the number {0} is: {1}", str, result.ToString());
    }

}

