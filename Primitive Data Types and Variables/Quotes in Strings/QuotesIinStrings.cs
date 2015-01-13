//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;


class QuotesIinStrings
{
    static void Main()
    {
        string stringOne = @"The ""use"" of quotations causes difficulties.";
        string stringTwo = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("with quoted: {0}", stringOne);
        Console.WriteLine("with escaped: {0}", stringTwo);

    }
}

