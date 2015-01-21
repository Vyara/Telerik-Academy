//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:

//n	    Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true


using System;



class ThirdDigitIs7
{
    static void Main()
    {
        string str;
        int number;
        
        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number));

        bool isThird = ((number / 100) % 10) == 7;

        Console.WriteLine("The third digit of the number {0} is 7: {1}", number, isThird);


    }
}

