//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:

//input	
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//output
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


using System;
using System.Text.RegularExpressions;



class ReplaceТags
{
    static void Main()
    {
        string input;

        //asks user for input
        Console.Write("Please enter a string: ");
        input = Console.ReadLine();

        //uses RegEx to replace all the tags accordingly
        string result = (Regex.Replace(input, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));

        //prints result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Result: ");
        Console.WriteLine(result);

    }
}

