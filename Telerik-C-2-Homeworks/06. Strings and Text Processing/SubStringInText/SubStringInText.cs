//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9


using System;



class SubStringInText
{
    static void Main()
    {
        string input;
        string target;
        //asks user for input
        Console.Write("Please enter text: ");
        input = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter a target sub-string: ");
        target = Console.ReadLine();

        //uses CountRepeatingSubstring() to find the result and prints it
        int result = CountRepeatingSubstring(input, target);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The sub-string {0} appears {1} times in the given text.", target, result);

    }

    //method for checking how many times times a sub-string is contained in a given text
    static int CountRepeatingSubstring(string text, string target)
    {
        int index = 0;
        int count = 0;
        while (true)
        {
            int found = text.IndexOf(target, index);

            if (found < 0)
            {
                break;
            }
            count++;
            index = found + 1;
        }

        return count;
    }
}

