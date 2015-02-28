//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class ReverseSentence
{
    static string[] punctuation = new string[] { ",", ".", "-", ":", ";", "!", "?" };
    static void Main()
    {
        string sentence;
        //asks user for a sentence
        Console.WriteLine("Please enter a sentence: ");
        sentence = Console.ReadLine();

        //split sentence using SentenceIntoArray()
        string[] splittedSentence = SentenceIntoArray(sentence);

        //removing punctuation, saving index and sign into a dictionary
        Dictionary<int, string> punctuationPlaces = new Dictionary<int, string>();
        
        //creating a list, so that we can remove punctuation from it
        List<string> splittedList = new List<string>(splittedSentence);


        for (int i = 0; i < splittedList.Count; i++)
        {
            if (punctuation.Contains(splittedList[i]))
            {
                punctuationPlaces[i] = splittedList[i];
            }
        }

        //removes punctuation signs
        foreach (var value in punctuationPlaces.Values)
        {
            splittedList.Remove(value);
        }


        //reverses list
        splittedList.Reverse();

        //inserts punctuation back into the reversed list
        for (int i = 0; i < splittedSentence.Length; i++)
        {
            if (punctuationPlaces.ContainsKey(i))
            {
                splittedList.Insert(i, punctuationPlaces[i]);
            }
        }

        //joins the array and converts it to a string
        var reversed = new StringBuilder();
        for (int i = 0; i < splittedList.Count; i++)
        {
            if (!punctuation.Contains(splittedList[i]))
            {
                reversed.Append(" " + splittedList[i]);
            }

            else
            {
                reversed.Append(splittedList[i]);
            }
        }

        string result = reversed.ToString();
        result = result.Trim();
        
        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Reversed:");
        Console.WriteLine(result);


    }
    //method for splitting sentence (adding spaces before and after punctuation
    static string[] SentenceIntoArray(string sentence)
    {
        foreach (var sign in punctuation)
        {
            sentence = sentence.Replace(sign, (" " + sign + " "));
        }

        string[] splitted = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return splitted;
    }

}

