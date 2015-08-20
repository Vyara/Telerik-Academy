//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.


using System;


class PrimeNumbers
{
    static void Main()
    {
        //creates an array of bools from 1 to 10 000 000
        bool[] arePrimes = new bool[10000000];

        //initializes the array with all values from 2 to 10 000 000 set to true
        for (int i = 2; i < arePrimes.Length; i++)
        {
            arePrimes[i] = true;
        }

        //locates the primes by using the Sieve of Eratosthenes algorithm
        for (int i = 2; i < Math.Sqrt(arePrimes.Length); i++)
        {
            if (arePrimes[i] == true)
            {
                for (long j = i * i; j < arePrimes.Length; j+= i)
                {
                    arePrimes[j] = false;
                }
            }
        }

        //prints the primes from 1 to 10 000 000(all with value true)
        Console.WriteLine("The prime numbers from 1 to 10 000 000 are:");
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < arePrimes.Length; i++)
        {
            if (arePrimes[i] == true)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

