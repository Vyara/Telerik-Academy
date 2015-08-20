//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4



using System;



class DecimalToHexadecimalNumber
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

        Console.WriteLine("the hexadecimal form of the number {0} is: {1}", str, result.ToString());
    }
}


