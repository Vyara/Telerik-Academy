//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;


class OddLines
{
    static void Main()
    {

        const string filePath = "../../OddLines/Oddlines.txt";
        Console.WriteLine("This program prints odd lines from a text file");
        Console.WriteLine("----------------------------------------------");

        //uses StreamReader create a stream and read from file
        using (StreamReader readFile = new StreamReader(filePath))
        {
            //counts lines
            int count = 1;

            //reads odd lines until the end of text
            while (!readFile.EndOfStream)
            {
                string line = readFile.ReadLine();
                if (count % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                count++;
            }
        }
    }
}

