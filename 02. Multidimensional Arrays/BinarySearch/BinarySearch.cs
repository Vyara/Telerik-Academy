//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


using System;



class BinarySearch
{
    static void Main()
    {
        string str;
        int N;
        int K;
        //asks for the lenght of the array
        do
        {
            Console.Write("Please enter array length N: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out N));

        //creates an array according to chosen type and lenght
        int[] chosenArray = new int[N];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Please enter int element {0} of the array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }
        //asks for element
        do
        {
            Console.Write("Please enter an integer K: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out K));

        //sorts the array
        int[] sortedArray = new int[chosenArray.Length];
        for (int i = 0; i < chosenArray.Length; i++)
        {
            sortedArray[i] = chosenArray[i];
        }
        Array.Sort(sortedArray);

        //searches for the element using Array.Binary search
        bool isFound = false;
        int? index = null;
        for (int i = 0; i < N; i++)
        {
            index = Array.BinarySearch(sortedArray, K - i);
            if (index >= 0)
            {
                isFound = true;
                index = Array.BinarySearch(sortedArray, K - i);
                break;
            }

        }

        //prints result
        Console.WriteLine("---------------------------------------------");
        if (isFound)
        {
            Console.WriteLine("The largest number in the array, that is <= K, is: {0}", sortedArray[(int)index]);
        }

        else
        {
            Console.WriteLine("No number which is <= K was found.");
        }
    }
}

