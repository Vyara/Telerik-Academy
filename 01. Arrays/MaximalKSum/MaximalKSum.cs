//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;



class MaximalKSum
{
    static void Main()
    {
        string str;
        int N;
        int K;

        //asks for integer N
        do
        {
            Console.Write("Please enter an integer N: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out N));

        //asks for integer K(K <= N)
        do
        {
            Console.Write("Please enter an integer K(should be <= N): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out K) || K > N);

        //creates an int array with length N
        int[] inputArray = new int[N];

        //intitializes an array with N elements based on user input
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write("Please enter int element {0}: ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        //sort and reverse the array(max in front)
        Array.Sort(inputArray);
        Array.Reverse(inputArray);

        //prints the first K elements(biggest elements, thus will have the max sum)
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("The {0} elements with the maximal sum are: ", K);
        for (int i = 0; i < K; i++)
        {
            Console.Write(inputArray[i] + " ");
        }
        Console.WriteLine();

    }
}

