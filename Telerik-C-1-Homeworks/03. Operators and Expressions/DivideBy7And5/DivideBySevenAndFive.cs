//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
//Examples:

//n	  Divided by 7 and 5?
//3	    false
//0	    false
//5	    false
//7	    false
//35    true
//140   true


using System;



class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isDiv = number % 5 == 0 && number % 7 == 0 && number != 0;
        Console.WriteLine("Is the number {0} divided by 7 and 5 without a remainder?: {1}", number, isDiv);

    }

}
