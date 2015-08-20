//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:

//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}


using System;
using System.Collections.Generic;



class AddingPolynomials
{
    static void Main()
    {
        //asks user to enter 2 polynomials by using InputPolynomial()
        decimal[] firsrPolynomial = InputPolynomial();
        decimal[] secondPolynomial = InputPolynomial();

        //adds two polynomials using AddingTwoPolynomials()
        List<decimal> result = AddingTwoPolynomials(firsrPolynomial, secondPolynomial);

        //prints result using PrintPolynomial()
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Sum: ");
        PrintPolynomial(result);
    }

    //method for asking user to enter a polynomial based on degree
    static decimal[] InputPolynomial()
    {
        int degree;
        string str;
        do
        {
            Console.Write("Please enter a polynomial degree: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out degree) || degree < 0);

        decimal[] polynomial = new decimal[degree + 1];

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Please enter coefficients");
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            do
            {
                Console.Write("x^{0}: ",i);
                polynomial[i] = decimal.Parse(Console.ReadLine());

            } while (!int.TryParse(str, out degree));
        }
        Console.WriteLine();
        return polynomial;
    }

    //method for adding two polynomials represented as arrays
    static List<decimal> AddingTwoPolynomials(decimal[] firstArray, decimal[] secondArray) 
    {
        int maxLength = Math.Max(firstArray.Length, secondArray.Length);
        int count = 0;
        List<decimal> result = new List<decimal>();
        while (count < maxLength)
        {
            if (count < firstArray.Length && count < secondArray.Length)
            {
                result.Add(firstArray[count] + secondArray[count]);
            }

            else if (count >= firstArray.Length && count < secondArray.Length)
            {
                result.Add(secondArray[count]);
            }

            else if (count >= secondArray.Length && count < firstArray.Length)
            {
                result.Add(firstArray[count]);
            }
            
            count++;
        }

        return result;
    }

    //method for printing a polynomial using the coefficients array
    static void PrintPolynomial(List<decimal> array)
    {
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.Write("{0}x^{1} ", array[i], i);
            if (i != 0)
            {
                Console.Write("+ ");
            }
        }
        Console.WriteLine();
    }
}

