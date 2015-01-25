//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	        90
//20	
//60	
//10	
//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1	        1
//1


using System;
using System.Threading;
using System.Globalization;



class SumOfNNumbers
{
    static void Main()
    {
        string str;
        int n;
        double addNumber;
        double sum = 0;

        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out n));

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Please enter a number: ");
                str = Console.ReadLine();
                Console.Clear();

            } while (!double.TryParse(str, out addNumber));
            sum += addNumber;

        }

        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

