//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                    result
//3, 2, 3, 4, 2, 2, 4       2, 3, 4

using System;


class MaximalIncreasingSequence
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

        int element = 0;
        //creates an array according to chosen type and lenght
        int[] chosenArray = new int[length];

        //asks for int array inputs and initializes array accordingly(inputs must be valid)
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter int element {0} of the first array: ", i);

            chosenArray[i] = int.Parse(Console.ReadLine());
        }

        //checks for repeating elements and counts those
        int longestSequence = 1;

        for (int i = 0; i < chosenArray.Length; i++)
        {
            //element = chosenArray[i];
            if (i + 1 < chosenArray.Length)
            {
                if (chosenArray[i] == chosenArray[i + 1] - 1)
                {
                    int count = 2;
                    while (i + count < chosenArray.Length)
                    {
                        while (chosenArray[i + count - 1] == chosenArray[i + count] - 1)
                        {
                            count++;
                            if (i + count + 1 > chosenArray.Length)
                            {
                                break;
                            }
                        }
                        break;
                    }

                    if (count > longestSequence)
                    {
                        longestSequence = count;
                        element = chosenArray[i];
                    }
                }
            }
        }
        //creates a new array with the max sequence
        int[] longestSequenceArray = new int[longestSequence];

        //initiallizes the array with longest sequence

        for (int i = 0; i < longestSequenceArray.Length; i++)
        {
            longestSequenceArray[i] = element + i;
        }

        //prints the array

        for (int i = 0; i < longestSequenceArray.Length; i++)
        {
            if (i == longestSequenceArray.Length - 1)
            {
                Console.Write(longestSequenceArray[i]);
            }
            else
            {
                Console.Write(longestSequenceArray[i] + ", ");
            }
        }

        Console.WriteLine();

    }
}

