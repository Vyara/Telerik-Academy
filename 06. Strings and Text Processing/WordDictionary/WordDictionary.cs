//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;
using System.Collections.Generic;



class WordDictionary
{
    static void Main()
    {
        //creates a dictionary
        var dictionary = new Dictionary<string, string>();

        //string with keys
        string[] keys = {".NET", "CLR", "namespace" }; //you can add your own, don't forget to add a value as well

        //string with values
        string[] values = { "platform for applications from Microsoft", "managed execution environment for .NET", "hierarchical organization of classes" };

        //initializes the dictionary with the key/value pairs
        for (int i = 0; i < keys.Length; i++)
        {
            dictionary[keys[i]] = values[i];
        }

        //aks user for input 
        Console.WriteLine(string.Join(", ",keys));
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter a word from the listed above: ");
        string input = Console.ReadLine();

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        string definition = dictionary[input];
        Console.WriteLine("{0}: {1}", input, definition);

        
    }
}

