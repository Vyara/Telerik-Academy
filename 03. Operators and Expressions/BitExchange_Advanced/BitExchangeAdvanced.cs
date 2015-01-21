//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	            p	q	k	    binary representation of n	                        binary result	                            result
//1140867093	3	24	3	    01000100 00000000 01000000 00010101	                01000010 00000000 01000000 00100101	        1107312677
//4294901775	24	3	3	    11111111 11111111 00000000 00001111	                11111001 11111111 00000000 00111111	        4194238527
//2369124121	2	22	10	    10001101 00110101 11110111 00011001	                01110001 10110101 11111000 11010001	        1907751121
//987654321	    2	8	11	    00111010 11011110 01101000 10110001	                -	                                        overlapping
//123456789	    26	0	7	    00000111 01011011 11001101 00010101	                -	                                        out of range
//33333333333	-1	0	33	    00000111 11000010 11010010 01001101 01010101	    -	                                        out of range



using System;



class BitExchangeAdvanced
{
    static void Main()
    {
        string str;
        ulong number;
        int p;
        int q;
        int k;

        do
        {
            Console.Write("Please enter an unsigned integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!ulong.TryParse(str, out number));


        do
        {
            Console.Write("Please enter a starting bit position (p): ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out p));

        do
        {
            Console.Write("Please enter a stating position (q): ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out q));


        do
        {
            Console.Write("Please enter the number of positions to be exchanged (k): ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out k));

        if (!(((p + k) <= 32) && ((q + k) <= 32)))
        {
            Console.WriteLine("Out of range");
        }

        else
        {
            if ((Math.Min(p,q)+ k > Math.Max(p,q)))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                //Console.WriteLine("n: " + number + "; n(binary): " + Convert.ToString(number, 2).PadLeft(32, '0'));
                for (int i = p; i < (k + p); i++)
                {
                    ulong bit1 = (number >> i) & 1;
                    int calc = ((q - p) + i);
                    ulong bit2 = ((number >> calc) & 1);
                    number = (ulong)(number & (ulong)(~(1 << calc)) | (bit1 << calc));
                    number = (ulong)(number & (ulong)(~(1 << i)) | (bit2 << i));
                }
                Console.WriteLine("Result: {0}  ", number);
            }
        }



    }
}

