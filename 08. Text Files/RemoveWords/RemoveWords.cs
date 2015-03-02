//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security;



class RemoveWords
{
    static void Main()
    {
        try
        {
            //path of the files
            const string textPath = "../../textfiles/text.txt";
            const string wordsPath = "../../textfiles/words.txt";
            const string resultPath = "../../textfiles/result.txt";
            //list for storage of the forbidden words
            List<string> blackList = new List<string>();

            string[] words = File.ReadAllLines(wordsPath);

            //goes through every string row of the text array
            for (int i = 0; i < words.Length; i++)
            {
                //splits row and assigns it to an array
                string[] currentRow = words[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //adds words to the black list
                foreach (var word in currentRow)
                {
                    if (!blackList.Contains(word))
                    {
                        blackList.Add(word);
                    }
                }
            }
            //removes words accordingly
            using (StreamReader reader = new StreamReader(textPath))
            {
                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string currentLine = blackList.Aggregate(reader.ReadLine(), (word, n) => Regex.Replace(word, "\\b" + n + "\\b", String.Empty, RegexOptions.IgnoreCase).Trim());
                        writer.WriteLine(currentLine);
                    }
                }
            }

            //prints the results
            ReadFile(textPath, "text");
            ReadFile(wordsPath, "words");
            ReadFile(resultPath, "result");
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
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


