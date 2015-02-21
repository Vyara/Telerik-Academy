//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Numerics;



class NumberAsArray
{
    static void Main()
    {
        string str;
        BigInteger firstNumber;
        BigInteger secondNumber;

        //asks user to enter two positive integer numbers
        do
        {
            Console.Write("Please enter a positive intgeger number: ");
            str = Console.ReadLine();

        } while (!BigInteger.TryParse(str, out firstNumber) || firstNumber < 0);

        Console.WriteLine("-------------------------------------------");

        do
        {
            Console.Write("Please enter a second intgeger number: ");
            str = Console.ReadLine();

        } while (!BigInteger.TryParse(str, out secondNumber) || secondNumber < 0);

        //uses AddNumbersAsArrays() to add the numbers
        List<int> result = AddNumbersAsArrays(firstNumber, secondNumber);

        //prints the result
        Console.WriteLine("-------------------------------------------");
        Console.Write("The sum of the numbers {0} and {1} is: ", firstNumber, secondNumber);
        PrintList(result);

    }
    //method for adding the numbers as described
    static List<int> AddNumbersAsArrays(BigInteger firstDecimal, BigInteger secondDecimal)
    {
        string firstNumber = firstDecimal.ToString();
        string secondNumber = secondDecimal.ToString();
        char[] firstArray = firstNumber.ToCharArray();
        char[] secondArray = secondNumber.ToCharArray();
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        List<int> sum = new List<int>();
        long count = 0;
        long maxLength =  Math.Max(firstArray.Length, secondArray.Length);
        int digitToCross = 0;
        while (count < maxLength)
        {
            if (count < firstArray.Length && count < secondArray.Length)
            {
                if (((firstArray[count] - '0') + (secondArray[count] - '0') + digitToCross) < 10)
                {
                    sum.Add((firstArray[count] - '0') + (secondArray[count] -'0') + digitToCross);
                    digitToCross = 0;
                }
                else
                {
                    int testSum = (firstArray[count] - '0') + (secondArray[count] - '0') + digitToCross;
                    int sumLastdigit = ((firstArray[count] - '0') + (secondArray[count] - '0') + digitToCross) % 10;
                    sum.Add(sumLastdigit);
                    digitToCross = ((firstArray[count] - '0') + (secondArray[count] - '0') + digitToCross) / 10;

                }
            }

            else if (count >= firstArray.Length && count < secondArray.Length)
            {
                if (((secondArray[count] - '0') + digitToCross) < 10)
                {
                    sum.Add((secondArray[count] - '0') + digitToCross);
                    digitToCross = 0;
                }
                else
                {
                    int sumLastdigit = ((secondArray[count] - '0') + digitToCross) % 10;
                    sum.Add(sumLastdigit);
                    digitToCross = ((secondArray[count] - '0') + digitToCross) / 10;
                }
            }

            else if (count >= secondArray.Length && count < firstArray.Length)
            {
                if (((firstArray[count] - '0') + digitToCross) < 10)
                {
                    sum.Add((firstArray[count] - '0') + digitToCross);
                    digitToCross = 0;
                }
                else
                {
                    int sumLastdigit = ((firstArray[count] - '0')+ digitToCross) % 10;
                    sum.Add(sumLastdigit);
                    digitToCross = ((firstArray[count] - '0') + digitToCross) / 10;
                }
            }
            count++;
        }
        if (digitToCross > 0)
        {
            sum.Add(digitToCross);
        }

        sum.Reverse();

        return sum;
    }

    //method for printing 
    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }
}

