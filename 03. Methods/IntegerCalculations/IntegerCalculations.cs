//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


using System;



class IntegerCalculations
{
    static void Main()
    {
        int length;
        string str;
        do
        {
            Console.Write("Please enter integer sequence lenght: ");
            str = Console.ReadLine();

            //checks if sequence length is zero
        } while (!int.TryParse(str, out length) || length <= 0);

        //creates an array according to given lenght
        long[] sequence = new long[length];

        //asks for int inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("-------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter integer {0} of the sequence: ", i + 1);

            sequence[i] = int.Parse(Console.ReadLine());
        }

        //uses method FindMinimum() to find a minimum
        long minimum = FindMinimum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The smallest number of the sequence is: {0}", minimum);

        //uses method FindMaximum() to find a maximum
        long maximum = FindMaximum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The largest number of the sequence is: {0}", maximum);

        //uses method FindAverage() to find the average
        decimal average = FindAverage(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The average of the sequence is: {0}", average);

        //uses method CalculateSum() to find the sum
        long sum = CalculateSum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The sum of the sequence is: {0}", sum);

        //uses method CalculateProduct() to find the product
        decimal product = CalculateProduct(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The product of the sequence is: {0}", product);


    }
    //method for calculating integer minimum
    static long FindMinimum(params long[] numbers)
    {
        long minNumber = long.MaxValue;
        foreach (var number in numbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        return minNumber;
    }

    //method for calculating integer maximum
    static long FindMaximum(params long[] numbers)
    {
        long maxNumber = long.MinValue;
        foreach (var number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        return maxNumber;
    }

    //method for calculating integer average
    static decimal FindAverage(params long[] numbers)
    {
        decimal sum = 0.0M;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

    //method for calculating integer sum
    static long CalculateSum(params long[] numbers)
    {
        long sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    //method for calculating integer product
    static decimal CalculateProduct(params long[] numbers)
    {
        decimal product = 1M;
        foreach (var number in numbers)
        {
            product *= number;
        }

        return product;
    }

}

