//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;



class BinarySearch
{
    static void Main()
    {
        string str;
        int length;
        int element;
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
        //asks for element
        do
        {
            Console.Write("Please enter an integer element value: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out element));

        //sorts the array
        int[] sortedArray = new int[chosenArray.Length];
        for (int i = 0; i < chosenArray.Length; i++)
        {
            sortedArray[i] = chosenArray[i];
        }
        Array.Sort(sortedArray);

        //finds the element using binary search
        int mid;
        int first = 0;
        int last = sortedArray.Length - 1;
        bool elementFound = false;

        while (first <= last)
        {
            mid = first + (last - first) / 2;
            if (element == sortedArray[mid])
            {
                elementFound = true;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Element {0} was found at index {1}.", sortedArray[mid], Array.IndexOf(chosenArray, sortedArray[mid]));
                break;
            }

            if (element < sortedArray[mid])
            {
                last = mid - 1;
            }

            else
            {

                first = mid + 1;
            }

        }

        if (!elementFound)
        {
            Console.WriteLine("Element {0} was not found in the array.", element);
        }


    }
}

