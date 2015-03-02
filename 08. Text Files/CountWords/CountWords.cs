//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.


using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;
using System.Linq;


class CountWords
{
    static void Main()
    {
        try
        {
            //path of the files
            const string textPath = "../../textfiles/text.txt";
            const string wordsPath = "../../textfiles/words.txt";
            const string resultPath = "../../textfiles/result.txt";
            //list for storage of the words
            List<string> wordsList = new List<string>();

            string[] words = File.ReadAllLines(wordsPath);

            //goes through every string row of the text array
            for (int i = 0; i < words.Length; i++)
            {
                //splits row and assigns it to an array
                string[] currentRow = words[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //adds words to the words list
                foreach (var word in currentRow)
                {
                    if (!wordsList.Contains(word.ToLower()))
                    {
                        wordsList.Add(word.ToLower());
                    }
                }
            }
            //creates a dictionary to hold word/count pairs
            var wordsCount = new Dictionary<string, int>();

            string[] text = File.ReadAllLines(textPath);

            //goes through every string row of the text array
            for (int i = 0; i < text.Length; i++)
            {
                //splits row and assigns it to an array
                string[] currentRow = text[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //adds word/count pairs to the dictionary
                for (int j = 0; j < currentRow.Length; j++)
                {

                    string currentWord = currentRow[j].ToLower().Trim(',', ' ', '-',';', ':', '/', '\\', '\"', '.');
                    if (wordsList.Contains(currentWord))
                    {
                        if (wordsCount.ContainsKey(currentWord))
                        {
                            wordsCount[currentWord]++;
                        }

                        else
                        {
                            wordsCount[currentWord] = 1;
                        }
                    }

                }
            }

            //writes results to the results file
            using (StreamReader reader = new StreamReader(textPath))
            {
                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                        foreach (var word in wordsCount.OrderByDescending(key => key.Value))
                        {
                            writer.WriteLine(word.Key + ": " + word.Value + " time/s");
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

