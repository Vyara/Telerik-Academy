//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	    output.txt
//Ivan          George 
//Peter         Ivan 
//Maria         Maria 
//George	    Peter


using System;
using System.IO;



class SaveSortedNames
{
    static void Main()
    {
        //path of the files
        const string inputPath = "../../textfiles/input.txt";
        const string outputPath = "../../textfiles/output.txt";

        //reading all lines from the first file
        string[] names = File.ReadAllLines(inputPath);

        //sorts the array
        Array.Sort(names);

        //writes strings to the output file
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            for (int i = 0; i < names.Length; i++)
            {
                writer.WriteLine(names[i]);
            }
        }

        //prints results
        ReadFile(inputPath, "input");
        ReadFile(outputPath, "output");
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
