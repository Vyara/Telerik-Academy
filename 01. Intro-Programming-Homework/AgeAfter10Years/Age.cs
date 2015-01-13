//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;



class Age
{
    static void Main()
    {
        string birthday;
        DateTime parsedbirthday;
        DateTime currentdate;
        int currentage;
        Console.Write("Please enter your birthday(dd/mm/yyyy): "); //haven't written code for exeption handling for this one yet, thus the format clarification, will add it later
        birthday = Console.ReadLine();
        parsedbirthday = Convert.ToDateTime(birthday);
        currentdate = DateTime.Today;
        // calculates and outputs current age and age after 10 years based on console input
        if (currentdate.Month < parsedbirthday.Month)
        {
            currentage = currentdate.Year - parsedbirthday.Year - 1;
            Console.WriteLine("Your current age is: {0} ", currentage);
            Console.WriteLine("Your age in 10 years will be: {0}", (currentage + 10));
            Console.ReadLine();
        }
        else if (currentdate.Month == parsedbirthday.Month)
        {
            if (currentdate.Day >= parsedbirthday.Day)
            {
                currentage = currentdate.Year - parsedbirthday.Year;
                Console.WriteLine("Your current age is: {0}", currentage);
                Console.WriteLine("Your age in 10 years will be: {0}", (currentage + 10));
                Console.ReadLine();
            }
            else
            {
                currentage = currentdate.Year - parsedbirthday.Year - 1;
                Console.WriteLine("Your current age is: {0} ", currentage);
                Console.WriteLine("Your age in 10 years will be: {0}", (currentage + 10));
                Console.ReadLine();
            }


        }

    }
}
