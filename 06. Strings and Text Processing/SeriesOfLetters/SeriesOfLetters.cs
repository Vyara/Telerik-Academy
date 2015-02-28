//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                        output
//aaaaabbbbbcdddeeeedssaa       abcdedsa



using System;
using System.Text;



class SeriesOfLetters
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();

        //creates a StringBuilder to hold the result
        var result = new StringBuilder();
        result.Append(input[0]);

        //checks if the last letter in the result is equal to the current letter and if not, adds it
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != result[result.Length - 1])
            {
                result.Append(input[i]);
            }
        }

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Result: ");
        Console.WriteLine(result);

    }
}

