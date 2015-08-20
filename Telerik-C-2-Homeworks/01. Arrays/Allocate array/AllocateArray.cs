//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.


using System;


class AllocateArray
{
    static void Main()
    {
        int[] arrayOf20 = new int[20];

        //initialize array
        for (int i = 0; i < arrayOf20.Length; i++)
        {
            arrayOf20[i] = i * 5;
        }

        //print array
        Console.Write("[");

        for (int i = 0; i < arrayOf20.Length; i++)
        {
            if (i == 19)
            {
                Console.Write(arrayOf20[i]);
            }
            else
            {
                Console.Write(arrayOf20[i] + ", ");
            }
        }

        Console.Write("]");
        Console.WriteLine();
    }
}

