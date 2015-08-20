//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.



using System;


class HexadecimalToDecimal
{
    static void Main()
    {
        string hexa;
        Console.Write("Please enter a hexadecimal number: ");
        hexa = Console.ReadLine();
        long decimalNumber = 0;
        int count = hexa.Length - 1;

        for (int i = 0; i < hexa.Length; i++)
        {

            switch (hexa[count])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decimalNumber += int.Parse(hexa[count].ToString()) * (long)Math.Pow(16, i);
                    break;
                case 'A': decimalNumber += 10 * (long)Math.Pow(16, i);
                    break;
                case 'B': decimalNumber += 11 * (long)Math.Pow(16, i);
                    break;
                case 'C': decimalNumber += 12 * (long)Math.Pow(16, i);
                    break;
                case 'D': decimalNumber += 13 * (long)Math.Pow(16, i);
                    break;
                case 'E': decimalNumber += 14 * (long)Math.Pow(16, i);
                    break;
                case 'F': decimalNumber += 15 * (long)Math.Pow(16, i);
                    break;

                default:
                    break;
            }

            count--;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The decimal form of the hexadecimal number {0} is: {1}", hexa, decimalNumber);
    }
}

