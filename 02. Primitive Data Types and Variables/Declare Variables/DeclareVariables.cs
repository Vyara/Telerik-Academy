//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;



class DeclareVariables
{
    static void Main()
    {
        ushort ushortVariable = 52130;
        sbyte sbyteVariable = -115;
        int intVariable = 4825932;
        byte byteVariable = 97;
        short shortVariable = -10000;
        Console.WriteLine("ushort variable: {0} ",ushortVariable);
        Console.WriteLine("sbyte variable {0}", sbyteVariable);
        Console.WriteLine("int variable {0}", intVariable);
        Console.WriteLine("byte variable {0}", byteVariable);
        Console.WriteLine("short variable {0}", shortVariable);

    }
}

