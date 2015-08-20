//Problem 16.* Subset with sum S

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:

//input array	            S	    result
//2, 1, 2, 4, 3, 5, 2, 6	14	    yes


using System;
using System.Collections.Generic;



class SubsetWithSumS
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
            Console.Write("Please enter int element {0} of the array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }

        //asks for a number S
        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter an integer S: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out S));

        //finds all subsets of the array set
        for (int i = 0; i < Math.Pow(2, chosenArray.Length); i++)
        {
            List<int> subset = new List<int>();
            for (int j = 0; j < chosenArray.Length; j++)
            {
                if ((i & (1 << (chosenArray.Length - j - 1))) != 0)
                {
                    subset.Add(chosenArray[j]);
                }

            }
            //sums up all the elements of each subset 
            int sum = 0;
            for (int k = 0; k < subset.Count; k++)
            {
                sum += subset[k];

            }

            //compares the sum of all subset elements with S
            if (sum == S)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Yes, there is a subset of elements in the array, that have a sum of {0}.", S);
                Console.Write("Elements of subset { ");
                for (int m = 0; m < subset.Count; m++)
                {
                    Console.Write(subset[m] + " ");
                }
                Console.Write("} ");
                Console.Write("have the sum {0}.", sum);
                Console.WriteLine();
            }

        }

    }
}

