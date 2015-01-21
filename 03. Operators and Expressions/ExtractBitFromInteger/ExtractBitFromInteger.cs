//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:

//n	    binary      representation	    p	bit @ p
//5	    00000000    00000101	        2	    1
//0	    00000000    00000000	        9	    0
//15	00000000    00001111	        1	    1
//5343	00010100    11011111	        7	    1
//62241	11110011    00100001	        11	    0


using System;


class ExtractBitFromInteger
{
    static void Main()
    {
        string str;
        int n;
        int p;

        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out n));

        do
        {
            Console.Write("Please enter a position index: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out p));
        
        int mask = 1 << p;
        long numberAndmask = n & mask;
        long bit = numberAndmask >> p;
        Console.WriteLine("Bit #{0} of the number {1}, is {2} .", p, n, bit);
    }
}

