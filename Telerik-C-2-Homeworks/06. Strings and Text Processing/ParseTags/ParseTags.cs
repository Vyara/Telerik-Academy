//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;
using System.Text.RegularExpressions;



class ParseTags
{
    static void Main()
    {
        string input;
        //asks user for input
        Console.Write("Please enter text: ");
        input = Console.ReadLine();

        //uses a regex expression and lambda to locate the target sub-string and make it upper case
        string upperText = Regex.Replace(input, "<upcase>(.*?)</upcase>", substring => substring.Groups[1].Value.ToUpper());

        //prints result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Formatted: ");
        Console.WriteLine(upperText);

    }

    
}

