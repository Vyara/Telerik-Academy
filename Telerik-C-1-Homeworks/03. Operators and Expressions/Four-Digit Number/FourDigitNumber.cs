//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n	    sum of digits	reversed	last digit in front	    second and third digits exchanged
//2011	    4	        1102	        1201	                2101
//3333	    12	        3333	        3333	                3333
//9876	    30	        6789	        6987	                9786


using System;



class FourDigitNumber
{
    static void Main()
    {
        string str;
        int number;

        do
        {
            Console.Write("Please enter a four digit integer, that doesn't start with 0: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number) || str.Length != 4 || str[0] == '0');

        int firstDig = number / 1000;
        int secondDig = (number / 100) % 10;
        int thirdDig = (number / 10) % 10;
        int fourthDig = number % 10;
        int sum = firstDig + secondDig + thirdDig + fourthDig;

        Console.WriteLine("The sum of the digits of the number {0}, is {1}", number, sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}",fourthDig, thirdDig, secondDig, firstDig);
        Console.WriteLine("With last digit in the first position: {0}{1}{2}{3}", fourthDig, firstDig, secondDig, thirdDig);
        Console.WriteLine("With second and third digits exchanged: {0}{1}{2}{3}", firstDig, thirdDig, secondDig, fourthDig);

    }
}

