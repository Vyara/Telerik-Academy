//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.



using System;



class OrderWords
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter words, separated by spaces: ");
        string input = Console.ReadLine();

        //splits user input
        string[] words = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        //sorts the array using Array.Sort
        Array.Sort(words);

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        string result = string.Join(", ", words);
        Console.WriteLine("Result: ");
        Console.WriteLine(result);
    }
}

