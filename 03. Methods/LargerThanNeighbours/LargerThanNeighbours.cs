//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;



class LargerThanNeighbours
{
    static void Main()
    {
        string str;
        int length;
        int index;

        //asks for the lenght of the array
        do
        {
            Console.Write("Please enter array length: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out length));

        //creates an array according to chosen type and lenght
        decimal[] decimalArray = new decimal[length];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter element {0} of the array: ", i);

            decimalArray[i] = decimal.Parse(Console.ReadLine());
        }

        //asks for an element index to look for(checks if the input is valid) 
        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter a valid index in the array: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out index) || index < 0 || index >= decimalArray.Length);

        //uses IsNumberLarger() to check
        bool result = IsNumberLarger(decimalArray, index);

        //prints the result
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Is element {0} larger than it's neighbours? {1}", index, result ? "Yes." : "No.");

    }
    //method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist)
    //if element has only one neighbour(first or last element), compares it only to this one neighbour
    static bool IsNumberLarger(decimal[] array, int position)
    {
        bool result = false;
        bool isBiggerThanPrevious = false;
        bool isBiggerThanNext = false;

        if (position - 1 >= 0)
        {
            if (position == array.Length - 1)
            {
                result = array[position] > array[position - 1];
            }

            else
            {
                isBiggerThanPrevious = array[position] > array[position - 1];
            }
        }

        if (position + 1 < array.Length)
        {
            if (position == 0)
            {
                result = array[position] > array[position + 1];
            }
            else
            {
                isBiggerThanNext = array[position] > array[position + 1];
            }

        }

        if (isBiggerThanNext && isBiggerThanPrevious)
        {
            result = true;
        }
        
        return result;

    }
}


