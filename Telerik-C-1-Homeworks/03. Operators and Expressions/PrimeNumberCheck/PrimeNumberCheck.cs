//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:

//n	    Prime?
//1	    false
//2	    true
//3	    true
//4	    false
//9	    false
//97	true
//51	false
//-3	false
//0	    false


using System;



class PrimeNumberCheck
{
    static void Main()
    {
        string str;
        int number;
        bool isPrime = true;

        do
        {
            Console.Write("Please enter an integer wich is less than or equal to 100: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number) || number > 100);

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }

        }
        
        if (number == 1 || number <= 0)
        {
            isPrime = false;
        }

        Console.WriteLine("The number {0} is prime?: {1}", number, isPrime);

    }

}
