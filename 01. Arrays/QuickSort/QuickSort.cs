//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.


using System;



class MergeSort
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

        //sorts the array using the quick method
        QuickSortMethod(chosenArray, 0, chosenArray.Length - 1);

        //prints the sorted array
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("sorted array: ");
        for (int i = 0; i < chosenArray.Length; i++)
        {
            Console.Write(chosenArray[i] + " ");
        }
        Console.WriteLine();


    }
    //partition method
    static public int Partition(int[] inputArray, int lo, int high)
    {
        int pivot = inputArray[lo];

        while (true)
        {
            while (inputArray[lo] < pivot)
            {
                lo++;
            }

            while (inputArray[high] > pivot)
            {
                high--;
            }

            //for equal numbers
            if (inputArray[high] == pivot && inputArray[lo] == pivot)
            {
                lo++;
            }

            if (lo < high)
            {
                int temp = inputArray[high];
                inputArray[high] = inputArray[lo];
                inputArray[lo] = temp;
            }
            else
            {
                return high;
            }
        }
    }
    
    //quick sort method
    public static void QuickSortMethod(int[] inputArray, int lo, int high)
    {
        if (lo < high)
        {
            int pivot = Partition(inputArray, lo, high);

            if (pivot > 1)
            {
                QuickSortMethod(inputArray, lo, pivot - 1);
            }

            if (pivot + 1 < high)
            {
                QuickSortMethod(inputArray, pivot + 1, high);
            }
        }
        
 
    }
}

