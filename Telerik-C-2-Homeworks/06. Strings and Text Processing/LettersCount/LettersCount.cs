//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.



using System;
using System.Collections.Generic;



class LettersCount
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();
        
        //asks user if he wants counted as case sensitive ot case insensitive
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Please choose the way letters will be counted: ");
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
                
        //creates a dictionary to hold letter/count pairs
        var letters = new Dictionary<char, int>();

        //adds letters and counts accordingly
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]]++;
                }

                else
                {
                    letters[input[i]] = 1;
                }
            }
        }

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Letters count: ");
        foreach (var letter in letters)
        {
            Console.WriteLine("{0}: {1}", letter.Key, letter.Value);
        }
    }
}

