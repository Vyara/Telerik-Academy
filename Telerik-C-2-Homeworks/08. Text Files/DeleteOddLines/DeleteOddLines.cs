//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.


using System;
using System.Collections.Generic;
using System.IO;



class DeleteOddLines
{
    static void Main()
    {
        //path of the file
        const string textPath = "../../textfiles/text.txt"; //"../../textfiles/initialtext.txt"  - original text before modification, should you wish to use it

        List<string> oddLines = new List<string>();
        int count = 1;


        using (StreamReader reader = new StreamReader(textPath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (count % 2 == 0)
                {
                    oddLines.Add(line);
                }
                count++;
            }
        }
        //print file before removing odd lines
        ReadFile(textPath, "before removing odd lines");

        using (StreamWriter writer = new StreamWriter(textPath))
        {
            foreach (var line in oddLines)
            {
                writer.WriteLine(line);
            }
        }

        //print file after removing odd lines
        ReadFile(textPath, "after removing odd lines");
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

