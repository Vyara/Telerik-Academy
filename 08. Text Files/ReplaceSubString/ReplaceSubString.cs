//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;



class ReplaceSubString
{
    static void Main()
    {
        //path of the files
        const string textPath = "../../textfiles/text.txt";
        const string resultPath = "../../textfiles/result.txt";

        //replaces substrings accordingly
        using (StreamReader reader = new StreamReader(textPath)) 
        {
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(reader.ReadLine().Replace("start", "finish").Replace("Start", "Finish"));
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

