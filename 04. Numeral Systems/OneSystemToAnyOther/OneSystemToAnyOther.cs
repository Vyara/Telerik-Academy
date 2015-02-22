//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).


using System;


class OneSystemToAnyOther
{
    static void Main()
    {
        string str;
        int s;
        int d;
        string number;

        //asks for user inputs
        do
        {
            Console.Write("Please enter base s (s >= 2): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out s) || s < 2);

        Console.WriteLine("---------------------------------------------");
        do
        {
            Console.Write("Please enter base d (d <= 16): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out d) || d > 16);

        Console.WriteLine("---------------------------------------------");

        Console.Write("Please enter a number to be converted from base {0} to base {1}: ", s, d);
        number = Console.ReadLine();

        //uses ConvertBetweenSystems() to convert between systems
        string result = ConvertBetweenSystems(number, s, d);

        //prints result
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Number {0} in base {1} is equal to {2} in base {3}", number, s, result, d);

    }

    //method for converting from one system to another
    static string ConvertBetweenSystems(string input, int firstBase, int secondBase)
    {
        int toDecimal = 0;


        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(input[i]))
            {
                toDecimal += (int)((input[i] - '0') * Math.Pow(firstBase, input.Length - i - 1));
            }
            else
            {
                int number = 0;

                input = input.ToUpper();
                switch (input[i])
                {
                    case 'A': number = 10;
                        break;
                    case 'B': number = 11;
                        break;
                    case 'C': number = 12;
                        break;
                    case 'D': number = 13;
                        break;
                    case 'E': number = 14;
                        break;
                    case 'F': number = 15;
                        break;
                }

                toDecimal += (int)(number * Math.Pow(firstBase, input.Length - i - 1));
            }
        }

        int remainder;
        string result = "";

        while (toDecimal > 0)
        {
            remainder = (int)(toDecimal % (int)secondBase);
            toDecimal /= (int)secondBase;

            if (remainder < 10)
            {
                result = remainder.ToString() + result;
            }
            else
            {
                switch (remainder)
                {
                    case 10: result = "A" + result;
                        break;
                    case 11: result = "B" + result;
                        break;
                    case 12: result = "C" + result;
                        break;
                    case 13: result = "D" + result;
                        break;
                    case 14: result = "E" + result;
                        break;
                    case 15: result = "F" + result;
                        break;
                }
            }
        }
        return result;
    }
}

