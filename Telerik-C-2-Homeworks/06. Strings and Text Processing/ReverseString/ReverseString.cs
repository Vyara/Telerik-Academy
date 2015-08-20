//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	    output
//sample	elpmas


using System;
using System.Text;



class ReverseString
{
    static void Main()
    {
        string input;
        //asks user for input
        Console.Write("Please enter a string: ");
        input = Console.ReadLine();

        //creates a StringBuilder and reverses the string
        var reversed = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        //prints the result
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Reversed: ");
        Console.WriteLine(reversed);

    }
}

