//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). 
//Example of incorrect expression: )(a+b)).


using System;




class CorrectBrackets
{
    static void Main()
    {
        string input;
        //asks user for input
        Console.Write("Please enter an expression with standart brackets: ");
        input = Console.ReadLine();


        //prints the result using areBracketsCorrect()
        Console.WriteLine("--------------------------------------------------------------");
        if (areBracketsCorrect(input))
        {
            Console.WriteLine("Expression {0} is correct.", input);
        }

        else
        {
            Console.WriteLine("Expression {0} is incorrect.", input);
        }
    }

    //method for checking if brackets are correctly placed
    private static bool areBracketsCorrect(string expression)
    {

        int count = 0;
        int openingBracketsCount = 0;
        int closingBracketsCount = 0;
        while (count < expression.Length)
        {
            if (expression[count] == '(')
            {
                openingBracketsCount++;
            }

            else if (expression[count] == ')')
            {
                closingBracketsCount++;
                if (openingBracketsCount == 0)
                {
                    return false;
                }
                else
                {
                    openingBracketsCount--;
                    closingBracketsCount--;
                }
            }
            count++;
        }

        if (openingBracketsCount != closingBracketsCount)
        {
            return false;
        }

        return true;

    }
}

