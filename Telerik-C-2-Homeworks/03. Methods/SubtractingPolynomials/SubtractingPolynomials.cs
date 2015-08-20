//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.


using System;
using System.Collections.Generic;


class SubtractingPolynomials
{
    static void Main()
    {
        //asks user to enter 2 polynomials by using InputPolynomial()
        decimal[] firsrPolynomial = InputPolynomial();
        decimal[] secondPolynomial = InputPolynomial();

        //adds two polynomials using AddingTwoPolynomials()
        List<decimal> sum = AddingTwoPolynomials(firsrPolynomial, secondPolynomial);
        List<decimal> difference = AddingTwoPolynomials(firsrPolynomial, secondPolynomial, false, true);
        List<decimal> product = AddingTwoPolynomials(firsrPolynomial, secondPolynomial, false, false, true);

        //prints results using PrintPolynomial()
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Sum: ");
        PrintPolynomial(sum);

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Differnece: ");
        PrintPolynomial(difference);

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Product: ");
        PrintPolynomial(product);

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

    //method for adding, substracting or multiplying two polynomials represented as arrays(uses optional bools)
    static List<decimal> AddingTwoPolynomials(decimal[] firstArray, decimal[] secondArray, bool addition = true, bool substraction = false, bool multiplication = false) 
    {
        int maxLength = Math.Max(firstArray.Length, secondArray.Length);
        int count = 0;
        List<decimal> result = new List<decimal>();
        while (count < maxLength)
        {
            if (count < firstArray.Length && count < secondArray.Length)
            {
                if (addition)
                {
                    result.Add(firstArray[count] + secondArray[count]);
                }

                if (substraction)
                {
                    result.Add(firstArray[count] - secondArray[count]);
                }

                if (multiplication)
                {
                    result.Add(firstArray[count] * secondArray[count]);
                }
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

