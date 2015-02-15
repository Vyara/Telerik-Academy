//Problem 18.* Remove elements from array

//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.
//Example:

//input	                        result
//6, 1, 4, 3, 0, 3, 6, 4, 5	    1, 3, 3, 4, 5

using System;
using System.Collections.Generic;



class RemoveElementsFromArray
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
            Console.Write("Please enter int element {0} of the array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }

        //finds all subsets of the array set
        int removedItemsCount = length;
        List<int> removedItems = new List<int>();
        List<int> remainingSubset = new List<int>();
        for (int i = 0; i < Math.Pow(2, chosenArray.Length); i++)
        {
            List<int> subset = new List<int>();
            int?[] subsetArray = new int?[chosenArray.Length];
            bool isSubsetCreated = false;
            int count = 0;
            for (int j = 0; j < chosenArray.Length; j++)
            {
                if ((i & (1 << (chosenArray.Length - j - 1))) != 0)
                {
                    subset.Add(chosenArray[j]);
                    subsetArray[j] = chosenArray[j];
                    isSubsetCreated = true;
                    count++;
                }

            }

            //finds out if all the elements in the subset are sorted in increasing order

            bool isOrdered = true;
            for (int k = 1; k < subset.Count; k++)
            {
                if (subset[k - 1] > subset[k])
                {
                    isOrdered = false;
                    break;
                }

            }

            //if subset is sorted accordingly, checks for the minimal lenght of removed items
            if (isOrdered && isSubsetCreated)
            {
                if (length - count < removedItemsCount)
                {
                    removedItemsCount = length - count;
                    removedItems.Clear();
                    remainingSubset.Clear();
                    for (int n = 0; n < subset.Count; n++)
                    {
                        remainingSubset.Add(subset[n]);
                    }

                    for (int m = 0; m < chosenArray.Length; m++)
                    {
                        if (subsetArray[m] != chosenArray[m])
                        {
                            removedItems.Add(chosenArray[m]);
                        }

                    }
                }

            }
        }



        //checks if the array was sorted in the first place, such that no elements need to be removed
        if (removedItemsCount == length)
        {
            bool isOrdered = true;
            for (int k = 1; k < length; k++)
            {
                if (chosenArray[k - 1] > chosenArray[k])
                {
                    isOrdered = false;
                    break;
                }

            }
            if (isOrdered)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("No items need to be removed so that the array is sorted. Number of removed items = 0");
            }
        }

        //prints the sorted subset and the removed items
        else
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Number of removed items: {0}.", removedItemsCount);
            Console.WriteLine("---------------------------------------------");
            Console.Write("Removed elements { ");
            for (int i = 0; i < removedItems.Count; i++)
            {
                Console.Write(removedItems[i] + " ");
            }
            Console.WriteLine("} ");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Remaining elements in array { ");
            for (int i = 0; i < remainingSubset.Count; i++)
            {
                Console.Write(remainingSubset[i] + " ");
            }
            Console.Write("} ");
            Console.WriteLine();

        }
    }
}

