//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.


using System;
using System.Text.RegularExpressions;


class ExtractSentences
{
    static void Main()
    {
        string input;
        string word;

        //asks user for input
        Console.Write("Please enter text: ");
        input = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter a word to look for: ");
        word = Console.ReadLine();
        word = word.ToLower();

        //spits sentences into arrays
        var sentences = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        //looks for sentences that have the word(uses Regex expression) and prints results
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Sentences with the word \"{0}\" in them: ", word);
        Console.WriteLine();
        foreach (var sentence in sentences)
        {

            if (Regex.Matches(sentence.ToLower(), string.Format(@"\b{0}\b", word)).Count != 0)
            {
                Console.WriteLine(sentence.Trim() + ".");
            }

        }

        Console.WriteLine();
    }
}
