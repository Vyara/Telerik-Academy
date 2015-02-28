//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;



class EnterNumbers
{
    static void Main()
    {
        int number = 1;
        for (int i = 0; i < 10; i++)
        {
            number = ReadNumber(number + 1, 99);
        }
    }
    //method that enters an integer number in a given range [start…end]
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            Console.Write("Please enter an integer number in the range[{0}...{1}]: ", start, end);
            number = int.Parse(Console.ReadLine());
        }
        catch 
        {

            throw;
        }

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

}

