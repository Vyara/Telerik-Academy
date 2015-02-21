//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).


using System;



class NumberCalculations
{
    static void Main()
    {
        int length;
        string str;
        do
        {
            Console.Write("Please enter number sequence lenght: ");
            str = Console.ReadLine();

            //checks if sequence length is zero
        } while (!int.TryParse(str, out length) || length <= 0);

        //creates an array according to given lenght
        decimal[] sequence = new decimal[length];

        //asks for int inputs and initializes array accordingly(inputs must be valid)
        Console.WriteLine("-------------------------------------------");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter number {0} of the sequence: ", i + 1);

            sequence[i] = decimal.Parse(Console.ReadLine());
        }

        //uses method FindMinimum() to find a minimum
        var minimum = FindMinimum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The smallest number of the sequence is: {0}", minimum);

        //uses method FindMaximum() to find a maximum
        var maximum = FindMaximum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The largest number of the sequence is: {0}", maximum);

        //uses method FindAverage() to find the average
        var average = FindAverage(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The average of the sequence is: {0}", average);

        //uses method CalculateSum() to find the sum
        var sum = CalculateSum(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The sum of the sequence is: {0}", sum);

        //uses method CalculateProduct() to find the product
        var product = CalculateProduct(sequence);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("The product of the sequence is: {0}", product);


    }
    //method for calculating integer minimum
    static T FindMinimum<T>(params T[] numbers) where T : IComparable<T>
    {
        T minNumber = numbers[0];
        foreach (var number in numbers)
        {
            if (number.CompareTo(minNumber) == -1)
            {
                minNumber = number;
            }
        }

        return minNumber;
    }

    //method for calculating integer maximum
    static T FindMaximum<T>(params T[] numbers) where T : IComparable<T>
    {
        T maxNumber = numbers[0];
        foreach (var number in numbers)
        {
            if (number.CompareTo(maxNumber) == 1)
            {
                maxNumber = number;
            }
        }

        return maxNumber;
    }

    //method for calculating integer average
    static T FindAverage<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic sum = 0;
        dynamic count = 0;
        foreach (var number in numbers)
        {
            sum += (dynamic)number;
            count++;
        }

        return sum / count;
    }

    //method for calculating integer sum
    static T CalculateSum<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic sum = 0;
        foreach (var number in numbers)
        {
            sum += (dynamic)number;
        }

        return sum;
    }

    //method for calculating integer product
    static T CalculateProduct<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic product = 1;
        foreach (var number in numbers)
        {
            product *= (dynamic)number;
        }

        return product;
    }

}

