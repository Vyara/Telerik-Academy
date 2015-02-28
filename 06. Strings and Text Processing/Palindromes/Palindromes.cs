//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


using System;
using System.Linq;


class Palindromes
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();

        //splits user input
        string[] splittedText = input.Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        //checks if a word is a palindrome(case insensitive)
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < splittedText.Length; i++)
        {
            string word = splittedText[i].ToLower();
            string reversed = new string(Enumerable.Range(1, word.Length).Select(n => word[word.Length - n]).ToArray());
            if (word == reversed)
            {
                Console.WriteLine(splittedText[i]);
            }

        }
    }

}


