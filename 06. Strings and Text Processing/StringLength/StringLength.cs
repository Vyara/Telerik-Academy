//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.


using System;
using System.Text;



class StringLength
{
    static void Main()
    {
        string input;
        //asks user for input
        Console.Write("Please enter text(max 20 characters): ");
        input = Console.ReadLine();

        if (input.Length <= 20)
        {
            input = input.PadRight(20, '*');
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(input);
        }

        else
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Text must be max 20 characters long.");
        }

    }
}

