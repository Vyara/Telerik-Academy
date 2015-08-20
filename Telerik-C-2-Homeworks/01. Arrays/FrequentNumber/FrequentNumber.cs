//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)

using System;



class FrequentNumber
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
        //checks for most frequent number in array
        int mostFrequentNum = 0;
        int currentNum = 0;
        int currentCount = 1;
        int bestCount = 0;
        for (int i = 0; i < chosenArray.Length; i++)
        {
            currentNum = chosenArray[i];
            if (i + 1 < chosenArray.Length)
            {
                for (int j = i + 1; j < chosenArray.Length; j++)
                {
                    if (chosenArray[j] == currentNum)
                    {
                        currentCount++;
                    }
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    mostFrequentNum = currentNum;
                }
                currentCount = 1;
            }
        }
        //prints the most frequent number and the number of times it appears in the array
        if (bestCount == 1)
        {
            Console.WriteLine("All elements appear once.");
        }
        else
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Most frequent number: {0}", mostFrequentNum);
            Console.WriteLine("Number of appearances: {0}", bestCount);
        }

    }
}

