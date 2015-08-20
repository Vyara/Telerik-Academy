//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;


class WordsCount
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();

        //asks user if he wants counted as case sensitive ot case insensitive
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Please choose the way words will be counted: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Case sensitive => 1");
        Console.WriteLine("Case insensitive => 2");
        string str;
        int choice;
        do
        {
            Console.Write("Please enter 1 or 2: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out choice) || (choice != 1 && choice != 2));

        //lowers case if chosen option is case insensitive
        if (choice == 2)
        {
            input = input.ToLower();
        }

        //splits user input
        string[] splittedText = input.Split(new char[] { ' ', ',', '.', ';', '!', '?', '\"' }, StringSplitOptions.RemoveEmptyEntries);

        //creates a dictionary to hold word/count pairs
        var words = new Dictionary<string, int>();

        //adds words and counts accordingly
        for (int i = 0; i < splittedText.Length; i++)
        {
            string word = splittedText[i];
            bool isWord = true;

            //checks if element is a word letter by letter
            for (int j = 0; j < word.Length; j++)
            {
                if (!char.IsLetter(word[j]))
                {
                    isWord = false;
                }
            }

            if (isWord)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }

                else
                {
                    words[word] = 1;
                }
            }

        }

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Words count: ");
        foreach (var word in words)
        {
            Console.WriteLine("{0}: {1}", word.Key, word.Value);
        }
    }
}

