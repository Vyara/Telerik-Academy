//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.


using System;



class VariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0} ", a);
        Console.WriteLine("b = {0}", b);
        int newA = b;
        b = a;
        a = newA;
        Console.WriteLine("new a = {0} ", a);
        Console.WriteLine("new b = {0}", b);
    }
}

