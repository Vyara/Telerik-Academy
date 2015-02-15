//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


using System;



class IndexOfLetters
{
    static void Main()
    {
        string word;
        

        //creates an array that has all the upper and lower letters in the English alphabet
        char[] alphabet = new char[52];

        //adds upper case letters
        for (int i = 0; i < alphabet.Length / 2; i++)
        {
            alphabet[i] = (char) (65 + i);
        }

        //adds lower case letters
        int count = 0;
        for (int i = alphabet.Length / 2; i < alphabet.Length; i++)
        {
            alphabet[i] = (char) (97 + count);
            count++;
        }

        //prints array with indices
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Alphabet array: ");
        for (int i = 0; i < alphabet.Length; i++)
        {
            Console.WriteLine("Letter: {0}, Index :{1};", alphabet[i], i);
        }
        Console.WriteLine();

        //asks for a word
        Console.Write("Please enter a word: ");
        word = Console.ReadLine();

        //prints the indices of the entered word as per their position in the array
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Word: {0}", word);
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(word[i]))
            {
                Console.WriteLine("Letter {0}: {1}, Index in the alphabet array: {2};", i, word[i], Array.IndexOf(alphabet, word[i]));
            }
        }
    }
}

