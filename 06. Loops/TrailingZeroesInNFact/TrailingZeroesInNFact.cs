//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	        trailing zeroes of n!	        explaination
//10	        2	                        3628800
//20	        4	                        2432902008176640000
//100000	    24999	                    think why


using System;
using System.Numerics;


class TrailingZeroesInNFact
{
    static void Main()
    {
        string str;
        int number;
        BigInteger NFactorial = 1;

        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number));

        for (int i = 1; i <= number; i++)
        {
            NFactorial *= i;
        }

        //note: takes some time for the 100000 number
        string stringFactorial = NFactorial.ToString();
        char[] charArray = stringFactorial.ToCharArray();
        Array.Reverse(charArray);
        long zeroCount = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] != '0')
            {
                break;
            }

            zeroCount++;
        }
        Console.WriteLine("The trailing zeroes of {0}! are: {1}", number, zeroCount);
    }
}

