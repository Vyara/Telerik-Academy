//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;


class FirstLargerThanNeighbours
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
        decimal[] decimalArray = new decimal[length];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter element {0} of the array: ", i);

            decimalArray[i] = decimal.Parse(Console.ReadLine());
        }

        //uses FirstLargerThanNeighbours() to return first element larger than neighbours. 
        int index = FirstLarger(decimalArray);

        //prints the result accordingly 
        if (index != -1)
        {
            decimal value = decimalArray[index];
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Еlement {0} with value {1} is larger than it's neighbour/s", index, value);
        }

        else
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("There is no element, that is larger than it's neighbours." );
        }
    }
    //method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element(uses method from the previous exercise)
    static int FirstLarger(decimal[] array)
    {
        int count = 0;
        while (count < array.Length)
        {
            if (IsNumberLarger(array, count))
            {
                return count;
            }
            count++;
        }

        return -1;
    }

    //method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist) - from previous exercise.  
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

