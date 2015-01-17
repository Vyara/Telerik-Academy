//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;


class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("null integer: {0}", nullInt);
        Console.WriteLine("null double: {0}", nullDouble);
        nullInt += 6;
        nullDouble += 12;
        Console.WriteLine("null integer with added value of 6: {0}", nullInt);
        Console.WriteLine("null double with added value of 12: {0}", nullDouble);
        nullInt = 6;
        nullDouble = 12;
        Console.WriteLine("null integer with changed value to 6: {0}", nullInt);
        Console.WriteLine("null double with changed value to 12: {0}", nullDouble);

    }
}

