//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds


using System;



class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] cards = new string[] {"J", "Q", "K", "A"};

        for (int i = 2; i < 15; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {   
                    case 0: Console.Write("{0} of spades, ", i < 11 ? i.ToString() : cards[(i - 11)]);
                        break;
                    case 1: Console.Write("{0} of clubs, ", i < 11 ? i.ToString() : cards[(i - 11)]);
                        break;
                    case 2: Console.Write("{0} of hearts, ", i < 11 ? i.ToString() : cards[(i - 11)]);
                        break;
                    case 3: Console.Write("{0} of diamonds ", i < 11 ? i.ToString() : cards[(i - 11)]);
                        break;

                }
            }
            Console.WriteLine();
        }
    }
}

