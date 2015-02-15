//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8      2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;



class MaximalSum
{
    static void Main()
    {
        string str;
        int length;
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

        //scans the array with one loop and finds the seqence of max given sum
        int bestSum = 0;
        int currentSum = 0; 
        int start = 0;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < chosenArray.Length; i++)
        {
            if (currentSum <= 0)
            {
                start = i;
                currentSum = 0;
            }

            currentSum += chosenArray[i];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = start;
                bestEnd = i;
            }
        }


            //print the max sequence list
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("max sequence: ");
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(chosenArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("best sum: {0}", bestSum);
        }
    }
