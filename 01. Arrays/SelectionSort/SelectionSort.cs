//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;



class SelectionSort
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

        //sort array using selection sort
        int smallest;
        int temp;
        for (int i = 0; i < chosenArray.Length; i++)
        {
            smallest = i;
            for (int j = i + 1; j < chosenArray.Length; j++)
            {
                if (j < chosenArray.Length)
                {
                    if (chosenArray[j] < chosenArray[smallest])
                    {
                        smallest = j;
                    }
                }
            }

            temp = chosenArray[i];
            chosenArray[i] = chosenArray[smallest];
            chosenArray[smallest] = temp;


        }

        //print sorted array
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("sorted array: ");
        for (int i = 0; i < chosenArray.Length; i++)
        {
            Console.Write(chosenArray[i] + " ");
        }
        Console.WriteLine();

    }
}

