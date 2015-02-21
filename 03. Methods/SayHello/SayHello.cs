//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	    output
//Peter	    Hello, Peter!


using System;


class SayHello
{
    static void Main()
    {
        //asks user for first name
        Console.Write("Please enter your first name: ");

        //uses method PrintName to print “Hello, <name>” on the console
        var name = Console.ReadLine();
        Console.WriteLine("---------------------------------------");
        PrintName(name);
    }

    //method for printing name
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0} ",name);
    }
}

