//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            3
//3 --> string	
//Please enter a string:	hello
//hello*	

//Example 2:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            2
//3 --> string	
//Please enter a double:	1.5
//2.5

using System;
using System.Threading;
using System.Globalization;



class IntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.WriteLine(@"Please choose a type:	
1 --> int	
2 --> double	
3 --> string");
        string input = Console.ReadLine();
        int choice = 0;
        string result = null;
        switch (input)
        {
            case "1": Console.Write("Please enter an integer: ");
                choice = 1;
                result = Console.ReadLine();
                break;
            case "2": Console.Write("Please enter a double: ");
                choice = 2;
                result = Console.ReadLine();
                break;
            case "3": Console.Write("Please enter a string: ");
                choice = 3;
                result = Console.ReadLine();
                break;
            default: Console.WriteLine("incorrect input");
                break;
                break;
        }

        switch (choice)
        {
            case 1:
            case 2: Console.WriteLine(double.Parse(result) + 1);
                break;
            case 3: Console.WriteLine(result + "*");
                break;
        }

    }
}

