//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score	result
//2	    20
//4	    400
//9	    9000
//-1	invalid score
//10	invalid score

using System;



class BonusScore
{
    static void Main()
    {
        string str;
        int score;

        do
        {
            Console.Write("Please enter an integer score: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out score));

        if (score > 0 && score < 4)
        {
            Console.WriteLine("Result: {0}", score * 10);
        }

        else if (score > 3 && score < 7)
        {
            Console.WriteLine("Result: {0}", score * 100);
        }

        else if (score > 6 && score < 10)
        {
            Console.WriteLine("Result: {0}", score * 1000);
        }
        
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

