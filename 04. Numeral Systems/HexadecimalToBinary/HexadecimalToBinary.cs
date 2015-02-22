//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;




class HexadecimalToBinary
{
    static void Main()
    {
        string hexa;
        Console.Write("Please enter a hexadecimal number: ");
        hexa = Console.ReadLine();
        string binaryNumber = "";
        string result = "";

        for (int i = 0; i < hexa.Length; i++)
        {
            hexa = hexa.ToUpper();
            switch (hexa[i])
            {
                case '0': binaryNumber += "0000";
                    break;
                case '1': binaryNumber += "0001";
                    break;
                case '2': binaryNumber += "0010";
                    break;
                case '3': binaryNumber += "0011";
                    break;
                case '4': binaryNumber += "0100";
                    break;
                case '5': binaryNumber += "0101";
                    break;
                case '6': binaryNumber += "0110";
                    break;
                case '7': binaryNumber += "0111";
                    break;
                case '8': binaryNumber += "1000";
                    break;
                case '9': binaryNumber += "1001";
                    break;
                case 'A': binaryNumber += "1010";
                    break;
                case 'B': binaryNumber += "1011";
                    break;
                case 'C': binaryNumber += "1100";
                    break;
                case 'D': binaryNumber += "1101";
                    break;
                case 'E': binaryNumber += "1110";
                    break;
                case 'F': binaryNumber += "1111";
                    break;

                default:
                    break;
            }

            if (binaryNumber[0] == '0')
            {
                if (binaryNumber[1] == '0')
                {
                    result = binaryNumber.Remove(0, 2);
                }

                else
                {
                    result = binaryNumber.Remove(0, 1);
                }
            }

            else
            {
                result = binaryNumber;
            }
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The binary form of the hexadecimal number {0} is: {1}", hexa, result);
    }
}

