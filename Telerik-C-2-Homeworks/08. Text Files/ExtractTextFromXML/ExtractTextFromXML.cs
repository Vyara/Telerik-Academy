//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Text.RegularExpressions;


class ExtractTextFromXML
{
    static void Main()
    {
        //path of the files
        const string xmlPath = "../../textfiles/xml.txt";
        const string resultPath = "../../textfiles/result.txt";

        //removes tags accordingly
        using (StreamReader reader = new StreamReader(xmlPath))
        {
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(Regex.Replace(reader.ReadLine(), @"<[^>]*>", " ").Trim());
                }
            }
        }

        //prints the results
        ReadFile(xmlPath, "xml");
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

