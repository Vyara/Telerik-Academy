//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;


class PrefixTest
{
    static void Main()
    {
        //path of the files
        const string textPath = "../../textfiles/text.txt";
        const string resultPath = "../../textfiles/result.txt";

        //removes words that start with test, case insensitive
        using (StreamReader reader = new StreamReader(textPath))
        {
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(Regex.Replace(reader.ReadLine(), @"\btest\S*", String.Empty, RegexOptions.IgnoreCase).Trim());
                }
            }
        }

        //prints the results
        ReadFile(textPath, "text");
        ReadFile(resultPath, "result");
    }
    //method for printing
    static void ReadFile(string path, string name)
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Reading file " + name + "...");
        using (StreamReader readFile = new StreamReader(path))
        {
            while (!readFile.EndOfStream)
            {
                string line = readFile.ReadLine();

                Console.WriteLine(line);

            }
            Console.WriteLine("End of file " + name + ".");
        }
    }
}


