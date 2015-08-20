//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


using System;
using System.Collections.Generic;



class SortByStringLength
{
    static void Main()
    {
        string str;
        int length;
        //asks for the lenght of the array
        do
        {
            Console.Write("Please enter array length: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out length));

        //creates an array according to chosen type and lenght
        string[] stringArray = new string[length];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter string element {0} of the array: ", i);

            stringArray[i] = Console.ReadLine();
        }
        
        //prints array before sorting
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Array before sorting: ");
        Console.Write("[ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        //sorts the array using Array.Sort method with lambda expression
        Array.Sort(stringArray, (x, y) => x.Length.CompareTo(y.Length));

        //prints the sorted array
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Sorted array: ");
        Console.Write("[ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

    }
}

