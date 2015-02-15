//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.


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

        //sorts the array using the merge sort method
        MergeSortMethod(chosenArray, 0, chosenArray.Length - 1);

        //prints the sorted array
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("sorted array: ");
        for (int i = 0; i < chosenArray.Length; i++)
        {
            Console.Write(chosenArray[i] + " ");
        }
        Console.WriteLine();


    }
    //merge method, used to merge parts in the MergeSortMethod
    static void Merge(int[] inputArray, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i;
        int endLeft;
        int numElements;
        int tempPosition;

        endLeft = (mid - 1);
        tempPosition = left;
        numElements = (right - left + 1);

        while ((left <= endLeft) && (mid <= right))
        {
            if (inputArray[left] <= inputArray[mid])
                temp[tempPosition++] = inputArray[left++];
            else
                temp[tempPosition++] = inputArray[mid++];
        }

        while (left <= endLeft)
            temp[tempPosition++] = inputArray[left++];

        while (mid <= right)
            temp[tempPosition++] = inputArray[mid++];

        for (i = 0; i < numElements; i++)
        {
            inputArray[right] = temp[right];
            right--;
        }
    }

    //MergeSortMethod, using recursion
    static void MergeSortMethod(int[] inputArray, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSortMethod(inputArray, left, mid);
            MergeSortMethod(inputArray, (mid + 1), right);

            Merge(inputArray, left, (mid + 1), right);
        }
    }
}
