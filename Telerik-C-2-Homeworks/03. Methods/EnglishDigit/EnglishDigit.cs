//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine


using System;


class EnglishDigit
{
    static void Main()
    {
        string str;
        decimal number;
        //asks user to enter an integers(using long)
        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();

        } while (!decimal.TryParse(str, out number));

        //prints the last digit as word using LastDigitAsWord()
        string result = LastDigitAsWord(number);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Last digit as word: {0}.", result);
    }

    //method for returning the last digit of an integer as a word
    static string LastDigitAsWord(decimal number)
    {
        int lastDigit = (int)(Math.Abs(number) % 10);
        string lastDigitWord = "";
        switch (lastDigit)
        {
            case 0: lastDigitWord = "zero";
                break;
            case 1: lastDigitWord = "one";
                break;
            case 2: lastDigitWord = "two";
                break;
            case 3: lastDigitWord = "three";
                break;
            case 4: lastDigitWord = "four";
                break;
            case 5: lastDigitWord = "five";
                break;
            case 6: lastDigitWord = "six";
                break;
            case 7: lastDigitWord = "seven";
                break;
            case 8: lastDigitWord = "eight";
                break;
            case 9: lastDigitWord = "nine";
                break;

        }

        return lastDigitWord;
    }
}

