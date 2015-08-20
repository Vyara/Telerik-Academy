//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.


using System;



class BinaryToDecimal
{
    static void Main()
    {
        string binary;
        Console.Write("Please enter a binary number: ");
        binary = Console.ReadLine();
        long decimalNumber = 0;
        int count = binary.Length - 1;

        for (int i = 0; i < binary.Length; i++)
        {

            if (binary[count] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }

            count--;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The decimal form of the binary number {0} is: {1}", binary, decimalNumber);
    }
}

