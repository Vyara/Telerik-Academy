//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	        comments
//1	        0
//3	        0 1 1
//10	    0 1 1 2 3 5 8 13 21 34


using System;



class FibonacciNumbers
{
    static void Main()
    {
        string str;
        int n;
        int a = 0;
        int b = 1;
        int c;

        do
        {
            Console.Write("Please enter a positive integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out n) || n < 0);

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == 1)
            {
                Console.Write("{0}, ", i);
            }
            else
            {
                c = a + b;
                Console.Write("{0}, ", c);
                a = b;
                b = c;
            }
        }
        Console.WriteLine();
    }
}

