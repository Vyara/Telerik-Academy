//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	                                                        Information
//http://telerikacademy.com/Courses/Courses/Details/212	        [protocol] = http 
//                                                              [server] = telerikacademy.com 
//                                                              [resource] = /Courses/Courses/Details/212


using System;
using System.Text;



class ParseURL
{
    static void Main()
    {
        string url;

        //asks user for input
        Console.Write("Please enter a URL address([protocol]://[server]/[resource]): ");
        url = Console.ReadLine();


        //parses data according instructions
        string protocol = url.Remove(6).Trim(':', '/');
        string address = url.Substring(protocol.Length).Trim(':');
        var splittedAddtress = address.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        string server = splittedAddtress[0];
        var resource = new StringBuilder();
        for (int i = 1; i < splittedAddtress.Length; i++)
        {
            resource.Append('/' + splittedAddtress[i]);
        }

        //prints the result
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);

    }
}

