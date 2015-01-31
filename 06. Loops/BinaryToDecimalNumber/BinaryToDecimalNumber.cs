//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary	                        decimal
//0	                                0
//11	                            3
//1010101010101011	                43691
//1110000110000101100101000000	    236476736

using System;



class BinaryToDecimalNumber
{
    static void Main()
    {
        string binary;
        Console.Write("Please enter a binary number: ");
        binary = Console.ReadLine();
        long decimalNumber = 0;
        int count = binary.Length - 1;
        
        for (int i = 0; i < binary.Length; i++)
        {

            if (binary[count] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }

            count--;
        }

        Console.WriteLine("The decimal form of the binary number {0} is: {1}", binary, decimalNumber);
    }
}

