//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                       S	        result
//4, 3, 1, 4, 2, 5, 8	       11	        4, 2, 5

using System;
using System.Collections.Generic;



class FindSumInArray
{
    static void Main()
    {
        string str;
        int length;
        int S;
        //asks for the lenght of the array
        do
        {
            Console.Write("Please enter array lenght: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out length));

        //creates an array according to chosen type and lenght
        int[] chosenArray = new int[length];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter int element {0} of the first array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }

        //asks for an integer sum
        do
        {
            Console.Write("Please enter a sum S: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out S));

        //loops throught the array looking for S and saves numbers in a list
        List<int> numbersSumS = new List<int>();
        int? sum = null;
        for (int i = 0; i < chosenArray.Length; i++)
        {
            if (sum == S)
            {
                break;
            }
            if (i + 1 < chosenArray.Length)
            {
                sum = chosenArray[i];
                numbersSumS.Add(chosenArray[i]);
                for (int j = i + 1; j < chosenArray.Length; j++)
                {
                    if (sum == S)
                    {
                        break;
                    }
                    else if (sum > S)
                    {
                        sum = null;
                        numbersSumS.Clear();
                        break;
                    }
                    sum += chosenArray[j];
                    numbersSumS.Add(chosenArray[j]);
                }
            }
        }

        //prints result if present, if not, says there is no such sequence
        Console.WriteLine("---------------------------------------------");
        if (numbersSumS.Count == 0)
        {
            Console.WriteLine("There is no sequence which sum equals to {0}", S);
        }
        else
        {
            Console.Write("The sequence, which sum is {0}, is: ", S);
            for (int i = 0; i < numbersSumS.Count; i++)
            {
                if (i == numbersSumS.Count - 1)
                {
                    Console.Write(numbersSumS[i]);
                }
                else
                {
                    Console.Write(numbersSumS[i] + "," + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

