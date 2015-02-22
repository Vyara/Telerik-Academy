//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;


class DecimalToHexadecimal
{
    static void Main()
    {
        string str;
        long number;

        do
        {
            Console.Write("Please enter a positive integer: ");
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
            remainder = number % 16;
            switch (remainder)
            {
                case 10: result = "A" + result;
                    break;
                case 11: result = "B" + result;
                    break;
                case 12: result = "C" + result;
                    break;
                case 13: result = "D" + result;
                    break;
                case 14: result = "E" + result;
                    break;
                case 15: result = "F" + result;
                    break;


                default: result = remainder.ToString() + result;
                    break;
            }
            number /= 16;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The hexadecimal form of the number {0} is: {1}", str, result.ToString());
    }
}

