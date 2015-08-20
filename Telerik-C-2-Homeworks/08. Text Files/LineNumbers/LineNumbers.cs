//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.


using System;
using System.IO;



class LineNumbers
{
    static void Main()
    {
        //paths of the 2 files
        const string withoutLines = "../../textfiles/withoutlines.txt";
        const string withLines = "../../textfiles/withlines.txt";

        //reading all lines from the first file
        string[] noLines = File.ReadAllLines(withoutLines);

        //writes the result into the result text file and adds numbers
        using (StreamWriter writer = new StreamWriter(withLines))
        {
            for (int i = 0; i < noLines.Length; i++)
            {
                writer.WriteLine("{0}. {1}", i + 1, noLines[i]);
            }

        }
        //prints files
        ReadFile(withoutLines, "withoutLines");
        ReadFile(withLines, "withLines");

    }
    //method for reading files
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
