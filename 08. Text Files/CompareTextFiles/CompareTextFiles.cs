//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;


class CompareTextFiles
{
    static void Main()
    {
        //paths of the 2 files
        const string firstText = "../../textfiles/text1.txt";
        const string secondText = "../../textfiles/text2.txt";
        int sameLinesCount = 0;
        int differentLinesCount = 0;
        int count = 1;

        //reads files and compares
        using (StreamReader firstReader = new StreamReader(firstText))
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Reading first file...");
            using (StreamReader secondReader = new StreamReader(secondText))
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Reading second file...");
                while (!firstReader.EndOfStream || !secondReader.EndOfStream)
                {
                    string currentLineFromFirst = firstReader.ReadLine();
                    string currentLineFromSecond = secondReader.ReadLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Line {0} from first: {1}", count, currentLineFromFirst);
                    Console.WriteLine("Line {0} from second: {1}", count, currentLineFromSecond);
                    if (currentLineFromFirst == currentLineFromSecond)
                    {
                        sameLinesCount++;
                        Console.WriteLine("Lines {0}: Equal", count);
                    }

                    else
                    {
                        differentLinesCount++;
                        Console.WriteLine("Lines {0}: Different", count);
                    }
                    count++;
                }
            }
        }

        ////prints the result
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Number of equal lines: " + sameLinesCount);
        Console.WriteLine("Number of different lines: " + differentLinesCount);

    }
}

