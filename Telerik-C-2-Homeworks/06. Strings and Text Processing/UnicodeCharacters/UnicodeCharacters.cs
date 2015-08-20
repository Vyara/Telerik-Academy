//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	    output
//Hi!	    \u0048\u0069\u0021


using System;
using System.Text;



class UnicodeCharacters
{
    static void Main()
    {
        string input;

        //asks user for input
        Console.Write("Please enter a string: ");
        input = Console.ReadLine();

        //uses ConvertToUnicode() and prints the result
        string result = ConvertToUnicode(input);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Result: ");
        Console.WriteLine(result);

    }
    
    //method for converting string to Unicode
    static string ConvertToUnicode(string text)
    {
        int count = 0;
        var formattedText = new StringBuilder();
        while (count < text.Length)
        {
            formattedText.Append(String.Format(@"\u{0:X4}", (int)text[count]));
            count++;
        }

        return formattedText.ToString();
    }
}
