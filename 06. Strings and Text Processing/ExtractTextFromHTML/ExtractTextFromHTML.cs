//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.


using System;
using System.Text.RegularExpressions;



class ExtractTextFromHTML
{
    static void Main()
    {
        //html string, could be replaced
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        //locates body, cleans it and prints it
        foreach (Match item in Regex.Matches(html, @"<\s*title\s*>.*?<\s*/\s*title\s*>"))
        {
            string title = item.ToString();
            Console.WriteLine("Title: " + Regex.Replace(title, @"<.*?>", " ").Trim());
        }

        Console.WriteLine();

        //locates body using Regex, cleans it and prints it
        foreach (Match item in Regex.Matches(html, @"<\s*body\s*>.*?<\s*/\s*body\s*>"))
        {
            string body = item.ToString();
            Console.WriteLine("Text: " + Regex.Replace(body, @"<.*?>", " ").Trim());
        }

        Console.WriteLine();
    }
}

