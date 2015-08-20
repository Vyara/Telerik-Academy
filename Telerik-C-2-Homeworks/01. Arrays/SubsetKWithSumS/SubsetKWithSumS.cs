//Problem 17.* Subset K with sum S

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.


using System;
using System.Collections.Generic;



class SubsetKWithSumS
{
    static void Main()
    {
        string str;
        int N;
        int K;
        int S;
        //asks for a number N
        do
        {
            Console.Write("Please enter an integer array length N: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out N));


        //asks for a number K
        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter an integer subset lenght K: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out K));

        //asks for a number S
        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter an integer sum S: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out S));

        //creates an array according to chosen type and lenght
        int[] chosenArray = new int[N];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Please enter int element {0} of the array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }

        //finds all subsets of the array set
        bool isSubsetPresent = false;
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

            //sums up all the elements of each subset if subset lenght equals K
            if (subset.Count == K)
            {


                int sum = 0;
                for (int k = 0; k < subset.Count; k++)
                {
                    sum += subset[k];

                }

                //compares the sum of all subset elements with S
                if (sum == S)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Yes, there is a subset of K elements in the array, that have a sum of {0}.", S);
                    Console.Write("Elements of subset { ");
                    for (int m = 0; m < subset.Count; m++)
                    {
                        Console.Write(subset[m] + " ");
                    }
                    Console.Write("} ");
                    Console.Write("have the sum {0}.", sum);
                    Console.WriteLine();
                    isSubsetPresent = true;
                }
            }

        }

        //idicates the absence of a subset with lenght K and sum S
        if (!isSubsetPresent)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("No, there isn't a subset of K elements in the array, that have a sum of {0}.", S);
        }
    }

}