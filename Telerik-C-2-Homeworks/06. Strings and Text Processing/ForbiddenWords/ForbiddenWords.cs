//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.


using System;
using System.Text.RegularExpressions;



class ForbiddenWords
{
    static void Main()
    {
        string input;

        //asks user for input
        Console.Write("Please enter text: ");
        input = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter forbidden words, separated by a comma: ");
        var forbiddenWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //uses regex to look for the words in the text and replaces them accordingly
        foreach (var word in forbiddenWords)
        {
            string formattedWord = word.ToLower();

            if (Regex.Matches(input.ToLower(), string.Format(@"\b{0}\b", formattedWord)).Count != 0)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

        }

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Formatted text: ");
        Console.WriteLine();
        Console.WriteLine(input);

    }
}

