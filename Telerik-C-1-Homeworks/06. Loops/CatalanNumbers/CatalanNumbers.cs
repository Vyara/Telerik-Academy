//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:

//n	Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845

using System;
using System.Numerics;



class CatalanNumbers
{
    static void Main()
    {
        string str;
        int numberN;
        BigInteger factorialTwoN = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNPlusOne = 1;


        do
        {
            Console.Write("Please enter a valid integer n: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out numberN) || numberN > 100 || numberN < 0);

        long twoTimesN = 2 * numberN;
        int nPlusOne = numberN + 1;

        // calculates n!, 2n! and (n + 1)!
        for (int i = 1; i <= twoTimesN; i++)
        {
            if (i <= numberN)
            {
                factorialN *= i;
            }
            if (i <= nPlusOne)
            {
                factorialNPlusOne *= i;
            }
            factorialTwoN *= i;
        }
        
        // calculates whole result
        BigInteger result = factorialTwoN / (factorialNPlusOne * factorialN);

        Console.WriteLine("C(n) = {0}", result);

    }
}

