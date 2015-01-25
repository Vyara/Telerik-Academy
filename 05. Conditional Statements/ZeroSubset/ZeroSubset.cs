//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//numbers	        result
//3 -2 1 1 8	    -2 + 1 + 1 = 0
//3 1 -7 35 22	    no zero subset
//1 3 -4 -2 -1	    1 + -1 = 0
//                  1 + 3 + -4 = 0
//                  3 + -2 + -1 = 0
//1 1 1 -1 -1	    1 + -1 = 0
//                  1 + 1 + -1 + -1 = 0
//0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 32 subsets with 32 if statements.


using System;



class ZeroSubset
{
    static void Main()
    {
        string str;
        int a;
        int b;
        int c;
        int d;
        int e;

        do
        {
            Console.Write("Please enter a number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out a));


        do
        {
            Console.Write("Please enter a second number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out b));

        do
        {
            Console.Write("Please enter a third number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out c));

        do
        {
            Console.Write("Please enter a fourth number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out d));

        do
        {
            Console.Write("Please enter a fifth number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out e));
        
        int sumab = a + b;
        int sumac = a + c;
        int sumad = a + d;
        int sumae = a + e;
        int sumbc = b + c;
        int sumbd = b + d;
        int sumbe = b + e;
        int sumcd = c + d;
        int sumce = c + e;
        int sumde = d + e;
        int sumabc = sumab + c;
        int sumabd = sumab + d;
        int sumabe = sumab + e;
        int sumbcd = sumbc + d;
        int sumbde = sumbd + e;
        int sumcde = sumcd + e;
        int sumabcd = sumabc + d;
        int sumabde = sumabd + e;
        int sumbcde = sumbcd + e;

        int sumall = a + b + c + d + e;

        bool noZerosubset = sumab != 0 && sumac != 0 && sumad != 0 && sumae != 0 && sumbc != 0 && sumbd != 0 && sumbe != 0 &&
            sumcd != 0 && sumce != 0 && sumde != 0 && sumabc != 0 && sumabd != 0 && sumabe != 0 && sumbcd != 0 && sumbde != 0 &&
            sumcde != 0 && sumabcd != 0 && sumabde != 0 && sumbcde != 0 && sumall != 0;

        if (noZerosubset)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            if (sumab == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, sumab);
            }
            if (sumac == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, c, sumac);
            }
            if (sumad == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, d, sumad);
            }
            if (sumae == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, e, sumae);
            }
            if (sumbc == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, c, sumbc);
            }
            if (sumbd == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, d, sumbd);
            }
            if (sumbe == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, e, sumbe);
            }
            if (sumcd == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, d, sumcd);
            }
            if (sumce == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, e, sumce);
            }
            if (sumde == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", d, e, sumde);
            }
            if (sumabc == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sumabc);
            }
            if (sumabd == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, sumabd);
            }
            if (sumabe == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, sumabe);
            }
            if (sumbcd == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, sumbcd);
            }
            if (sumbde == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, d, e, sumbde);
            }
            if (sumcde == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumcde);
            }
            if (sumabcd == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, sumabcd);
            }
            if (sumabde == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, sumabde);
            }
            if (sumbcde == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumbcde);
            }
            if (sumall == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, sumall);
            }
        }
    }
}

