//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;



class ReplaceWholeWord
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
                    writer.WriteLine(Regex.Replace(reader.ReadLine(), @"\bstart\b", "finish", RegexOptions.IgnoreCase));
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


