//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;


class BinaryToHexadecimal
{
    static void Main()
    {
        string binary;
        string userInput;
        Console.Write("Please enter a binary number: ");
        userInput = Console.ReadLine();
        binary = userInput;
        //adding leading zeroes
        for (int i = 0; i < (binary.Length % 4); i++)
        {
            binary = "0" + binary;
        }
        string hexa = "";
        for (int i = 0; i < binary.Length; i += 4)
        {

            switch (binary.Substring(i, 4))
            {
                case "0000": hexa += '0';
                    break;
                case "0001": hexa += '1';
                    break;
                case "0010": hexa += '2';
                    break;
                case "0011": hexa += '3';
                    break;
                case "0100": hexa += '4';
                    break;
                case "0101": hexa += '5';
                    break;
                case "0110": hexa += '6';
                    break;
                case "0111": hexa += '7';
                    break;
                case "1000": hexa += '8';
                    break;
                case "1001": hexa += '9';
                    break;
                case "1010": hexa += 'A';
                    break;
                case "1011": hexa += 'B';
                    break;
                case "1100": hexa += 'C';
                    break;
                case "1101": hexa += 'D';
                    break;
                case "1110": hexa += 'E';
                    break;
                case "1111": hexa += 'F';
                    break;

                default:
                    break;
            }

        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The hexadecimal form of the binary number {0} is: {1}", userInput, hexa);
    }

}

