//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	            result
//2 1 1 6 3	            yes
//product = 6	
//3 10 4 6 5 1	        yes
//product = 60	
//4 3 2 5 2	            no
//odd_product = 16	
//even_product = 15	

using System;



class OddAndEvenProduct
{
    static void Main()
    {

        Console.Write("Please enter integers, separated by a space: ");

        string[] numbers = Console.ReadLine().Split(' ');


        long productEven = 1;
        long productOdd = 1;

        for (int i = 0; i < numbers.Length; i += 2)
        {
            productEven *= int.Parse(numbers[i]);
        }

        for (int i = 1; i < numbers.Length; i+= 2)
        {
             productOdd *= int.Parse(numbers[i]);
        }

        if (productEven == productOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("Product = {0}", productEven);
        }

        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Even product = {0}", productEven);
            Console.WriteLine("Odd product = {0}", productOdd);
        }
    }

}