//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.


using System;



class SquareRoot
{
    static void Main()
    {
        try
        {
            //tries user input
            Console.Write("Please enter a positive integer: ");
            uint number = uint.Parse(Console.ReadLine());
            //calculates result
            Console.WriteLine("The square root of {0} is {1:F2}", number, Math.Sqrt(number));
        }
        catch 
        {
            //if input is invalid, writes "Invalid number"
            Console.WriteLine("Invalid number");
            
        }
        finally
        {
            //writes "Good bye" in all cases
            Console.WriteLine("Good bye");
        }
    }
}
