//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:

//n	    binary      representation of n	    p	    bit @ p == 1
//5	    00000000    00000101	            2	    true
//0	    00000000    00000000	            9	    false
//15	00000000    00001111	            1	    true
//5343	00010100    11011111	            7	    true
//62241	11110011    00100001	            11	    false


using System;



class CheckABitAtGivenPosition
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
        bool isOne = numberAndmask > 0;
        Console.WriteLine("Bit #{0} of the number {1}, is 1?: {2} ", p, n, isOne);
    }
}

