//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.


using System;
using System.Text;


class StringsInCSharp
{
    static void Main()
    {
        //creates and prints description StringBuilder
        Console.WriteLine("DESCRIPTION: ");
        var description = new StringBuilder();
        description.AppendFormat("- A string is an object of type String whose value is text.");
        description.Append(Environment.NewLine);
        description.Append("- Strings are immutable (read-only) sequences of characters.");
        description.Append(Environment.NewLine);
        description.Append("- Each character is a Unicode symbol.");
        description.Append(Environment.NewLine);
        description.Append("- Represented by the string data type in C# (System.String).");
        Console.WriteLine(description);
        Console.WriteLine("--------------------------------------------------------------");
        
        //creates and prints features StringBuilder
        Console.WriteLine("FEATURES: ");
        var features = new StringBuilder();
        features.Append("- System.String is a reference type.");
        features.Append(Environment.NewLine);
        features.Append("- Strings have fixed length (String.Length).");
        features.Append(Environment.NewLine);
        features.Append("- Elements can be accessed directly by index in the range [0...Length-1].");
        Console.WriteLine(features);
        Console.WriteLine("--------------------------------------------------------------");

        //creates and prints methods StringBuilder
        Console.WriteLine("IMPORTANT METHODS: ");
        var methods = new StringBuilder();
        methods.AppendFormat("- Compare(str1, str2): {0}Compares substrings of two specified String objects, ignoring or honoring their case.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- IndexOf(str): {0}Reports the zero-based index of the first occurrence of the specified string in this instance.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- LastIndexOf(str): {0}Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- Substring(startIndex, length): {0}Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- Replace(oldStr, newStr): {0}Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- Remove(startIndex, length): {0}Removes the specified range of characters from this instance.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- ToLower(): {0}Returns a copy of this string converted to lowercase.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- ToUpper():  {0}Returns a copy of this string converted to uppercase.", Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.Append(Environment.NewLine);
        methods.AppendFormat("- Trim(): {0}Removes all leading and trailing white-space characters from the current String object.", Environment.NewLine);
        Console.WriteLine(methods);





    }
}

