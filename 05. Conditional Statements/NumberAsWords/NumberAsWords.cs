//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:

//numbers	number as words
//0	    Zero
//9	    Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

using System;



class NumberAsWords
{
    static void Main()
    {
        string str;
        int number;

        do
        {
            Console.Write("Please enter an integer from 0 to 999: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number) || number > 999 || number < 0);



        int firstDig = number / 100;
        int secondDig = (number / 10) % 10;
        int thirdDig = number % 10;

        switch (firstDig)
        {
            case 1: Console.Write("One ");
                break;
            case 2: Console.Write("Two ");
                break;
            case 3: Console.Write("Three ");
                break;
            case 4: Console.Write("Four ");
                break;
            case 5: Console.Write("Five ");
                break;
            case 6: Console.Write("Six ");
                break;
            case 7: Console.Write("Seven ");
                break;
            case 8: Console.Write("Eight ");
                break;
            case 9: Console.Write("Nine ");
                break;
        }
        if (firstDig != 0)
        {
            Console.Write("hundred ");
            if (secondDig != 0 || thirdDig != 0)
            {
                Console.Write("and ");
            }
        }

        if (secondDig == 1)
        {
                    switch (thirdDig)
        {
            case 0: Console.Write("ten");
                break;
            case 1: Console.Write("eleven");
                break;
            case 2: Console.Write("twelve");
                break;
            case 3: Console.Write("thirteen");
                break;
            case 4: Console.Write("fourteen");
                break;
            case 5: Console.Write("fifteen");
                break;
            case 6: Console.Write("sixteen");
                break;
            case 7: Console.Write("seventeen");
                break;
            case 8: Console.Write("eightteen");
                break;
            case 9: Console.Write("nineteen");
                break;
        }
        }

        else
        {
            switch (secondDig)
            {
                case 2: Console.Write("twenty ");
                    break;
                case 3: Console.Write("thirty");
                    break;
                case 4: Console.Write("fourty ");
                    break;
                case 5: Console.Write("fifty ");
                    break;
                case 6: Console.Write("sixty ");
                    break;
                case 7: Console.Write("seventy ");
                    break;
                case 8: Console.Write("eighty ");
                    break;
                case 9: Console.Write("ninety ");
                    break;
            }
        }

        if (secondDig != 1)
        {
                    switch (thirdDig)
        {
            case 0: if(firstDig == 0 && secondDig == 0)  Console.Write("zero");
            break;
            case 1: Console.Write("one");
                break;
            case 2: Console.Write("two");
                break;
            case 3: Console.Write("three");
                break;
            case 4: Console.Write("four");
                break;
            case 5: Console.Write("five");
                break;
            case 6: Console.Write("six");
                break;
            case 7: Console.Write("seven");
                break;
            case 8: Console.Write("eight");
                break;
            case 9: Console.Write("nine");
                break;
        }
        }
        Console.WriteLine();
    }
}

