//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;



class SolveTasks
{
    static void Main()
    {
        //creates a menu for use with options to chose from
        int choice;
        string str;
        Console.WriteLine("Please cho0se from the following options: ");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Reverse the digits of a number => 1");
        Console.WriteLine("Calculate the average of a sequence of integers => 2");
        Console.WriteLine("Solve a linear equation a * x + b = 0 => 3");
        Console.WriteLine("-------------------------------------------");
        do
        {
            Console.Write("Please enter 1, 2 or 3: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out choice) || (choice != 1 && choice != 2 && choice != 3));

        //asks for user input and validates data accordingly
        Console.WriteLine("-------------------------------------------");
        if (choice == 1)
        {
            decimal number;
            do
            {
                Console.Write("Please enter a non-negative decimal number: ");
                str = Console.ReadLine();
                //checks if number is decimal and if number is > 0
            } while (!decimal.TryParse(str, out number) || number < 0);

            //uses ReverseGivenNumber() to reverse number
            decimal result = ReverseGivenNumber(number);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Reversed number: {0}", result);
        }

        if (choice == 2)
        {
            int length;
            do
            {
                Console.Write("Please enter sequence lenght(should be > 0): ");
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

            //uses AverageOfSequence() to find average
            decimal result = AverageOfSequence(sequence);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Average of sequence: {0}", result);
        }

        if (choice == 3)
        {
            decimal a;
            decimal b;
            Console.WriteLine("Solving a * x + b = 0");
            do
            {
                Console.Write("Please enter number a (should not be zero): ");
                str = Console.ReadLine();

                //makes sure a != 0
            } while (!decimal.TryParse(str, out a) || a == 0);

            do
            {
                Console.Write("Please enter number b: ");
                str = Console.ReadLine();


            } while (!decimal.TryParse(str, out b));

            //uses SolvingLinearEquation() to solve the equation
            decimal result = SolvingLinearEquation(a, b);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("{0} * x + {1} = 0", a, b);
            Console.WriteLine("x = {0:F2}", result);

        }
    }
    //method for reversing the digits of a number
    static decimal ReverseGivenNumber(decimal number)
    {
        string numberToString = number.ToString();
        string reversed = "";
        for (int i = 0; i < numberToString.Length; i++)
        {
            reversed += numberToString[numberToString.Length - 1 - i];
        }
        decimal reversedNumber = decimal.Parse(reversed);
        return reversedNumber;
    }

    //method for calculating the average of a sequence of integers
    static decimal AverageOfSequence(long[] array)
    {
        decimal sum = 0.0M;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        decimal average = sum / array.Length;
        return average;
    }

    //method for solving a linear equation a * x + b = 0
    static decimal SolvingLinearEquation(decimal a, decimal b)
    {
        decimal result = 0.0M;
        result = -b / a;
        return result;
    }

}

