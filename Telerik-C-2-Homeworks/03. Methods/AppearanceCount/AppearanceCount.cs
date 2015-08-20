//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;


class AppearanceCount
{
    static void Main()
    {
        string str;
        int length;
        decimal number;

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
        
        //asks for a number to look for 
        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter a number to look for in the array: ");
            str = Console.ReadLine();

        } while (!decimal.TryParse(str, out number));

        //uses CountAppearances() to count how many times the given number appears in the given array
        int result = CountAppearances(decimalArray, number);

        //prints the result
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The number {0} appears {1} time/s in the array.", number, result);
    }

    //method for counting appearances of a number in an array
    static int CountAppearances(decimal[] array, decimal number)
    {
        int count = 0;
        int numberCount = 0;
        while (count < array.Length)
        {
            if (array[count] == number)
            {
                numberCount++;
            }
            count++;
        }
        return numberCount;
    }
}

