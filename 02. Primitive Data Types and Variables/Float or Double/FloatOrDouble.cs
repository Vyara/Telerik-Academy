//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;


class FloatOrDouble
{
    static void Main()
    {
        double firstDouble = 34.567839023;
        float firstFloat = 12.345F;
        double secondDouble = 8923.1234857;
        float secondFloat = 3456.091F;
        Console.WriteLine("double: {0}", firstDouble);
        Console.WriteLine("float: {0}", firstFloat);
        Console.WriteLine("double: {0}", secondDouble);
        Console.WriteLine("float: {0}", secondFloat);
    }

}