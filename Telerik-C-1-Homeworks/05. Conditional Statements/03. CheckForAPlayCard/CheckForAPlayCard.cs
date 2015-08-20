//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character	Valid card sign?
//5	    yes
//1	    no
//Q	    yes
//q	    no
//P	    no
//10	yes
//500	no

using System;


class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Please enter a sign: ");
        string sign = Console.ReadLine();
        bool isCard = false;
        
        switch (sign)
        {
            case "2": isCard = true;
                break;
            case "3": isCard = true;
                break;
            case "4": isCard = true;
                break;
            case "5": isCard = true;
                break;
            case "6": isCard = true;
                break;
            case "7": isCard = true;
                break;
            case "8": isCard = true;
                break;
            case "9": isCard = true;
                break;
            case "10": isCard = true;
                break;
            case "J": isCard = true;
                break;
            case "Q": isCard = true;
                break;
            case "K": isCard = true;
                break;
            case "A": isCard = true;
                break;

        }
        Console.WriteLine("Is the symbol {0} a playing card?: {1}" , sign, isCard ? "yes" : "no");
    }
}

