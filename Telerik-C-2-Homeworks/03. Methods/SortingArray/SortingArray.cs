//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;



class SortingArray
{
    static void Main()
    {
        long[] array = { 1, -2, 0, 5, -13, 2, 8, 2, 3 }; //change to test with a different array
        long[] decsResult = SortIntArray(array);
        long[] ascResult = SortIntArray(array, true);
        Console.Write("Initial array: ");
        PrintArray(array);
        Console.WriteLine("-------------------------------------------");
        Console.Write("Sorted in ascending order: ");
        PrintArray(ascResult);
        Console.WriteLine("-------------------------------------------");
        Console.Write("Sorted in descending order: ");
        PrintArray(decsResult);

    }
    //method that returns the maximal element in a portion of array of integers starting at given index
    static long MaxElement(long[] array, int startIndex, int stopIndex)
    {
        long maxElement = long.MinValue;
        for (int i = startIndex; i < stopIndex; i++)
        {
            if (maxElement < array[i])
            {
                maxElement = array[i];
            }
        }

        return maxElement;
    }

    //method that uses MaxElement() and sorts the array in ascending, descending order(sorts in ascending order by default, could be set to sort in descending)
    static long[] SortIntArray(long[] intArray, bool ascending = false)
    {
        long[] array = new long[intArray.Length];
        Array.Copy(intArray, array, array.Length);

        if (!ascending)
        {
            int count = 0;
            while (count < array.Length)
            {

                long temp = array[count];
                long maxElement = MaxElement(array, count, array.Length);
                int maxIndex = Array.IndexOf(array, maxElement, count);
                array[count] = maxElement;
                array[maxIndex] = temp;

                count++;
            }

        }
        else
        {
            int count = array.Length -1;
            while (count >= 0)
            {

                long temp = array[count];
                long maxElement = MaxElement(array, 0, count + 1);
                int maxIndex = Array.IndexOf(array, maxElement, 0, count + 1);
                array[count] = maxElement;
                array[maxIndex] = temp;

                count--;
            }
        }

        return array;
    }
    
    //method for printing arrays
    static void PrintArray(long[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

