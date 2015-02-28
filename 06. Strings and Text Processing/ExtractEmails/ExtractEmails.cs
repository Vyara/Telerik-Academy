//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.



using System;
using System.Linq;
using System.Text.RegularExpressions;






class ExtractEmails
{
    static void Main()
    {
        //asks user for input
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();

        //splits text with separators
        string[] splittedText = input.Split(new char[] { ' ', ',', '?', '!', '(', ')', '{', '}', '[', ']', '\"', ':' }, StringSplitOptions.RemoveEmptyEntries);

        //checks potential emails with a RegEx expression and prints them 
        Console.WriteLine("--------------------------------------------------");
       for (int i = 0; i < splittedText.Length; i++)
       {
           string email = splittedText[i].Trim('.', '-', '/', '\\');
           if (Regex.IsMatch(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
           {
               Console.WriteLine(email);
           }
       }

    }
}

