//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.



using System;
using System.IO;



class ConcatenateTextFiles
{
    static void Main()
    {
        //paths of the 3 files
        const string firstText = "../../textfiles/textfile1.txt";
        const string secondText = "../../textfiles/textfile2.txt";
        const string result = "../../textfiles/concatenatedfiles.txt";

        //reading all lines from the first file
        string[] firstFile = File.ReadAllLines(firstText);

        //reading all lines from the second file
        string[] secondFile = File.ReadAllLines(secondText);

        //writes the results into the result text file
        using (StreamWriter writer = new StreamWriter(result))
        {
            for (int i = 0; i < firstFile.Length; i++)
            {
                writer.WriteLine(firstFile[i], result[i]);
            }

            for (int i = 0; i < secondFile.Length; i++)
            {
                writer.WriteLine(secondFile[i], result[i]);
            }
        }

        //using ReadFile to read from the 3 files
        ReadFile(firstText, "firstText");
        ReadFile(secondText, "secondText");
        ReadFile(result, "result");


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

