//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

//Example input:

//program	        user
//Company name:	    Telerik Academy
//Company address:	31 Al. Malinov, Sofia
//Phone number:	    +359 888 55 55 555
//Fax number:	     2
//Web site:	        http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	+359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  


using System;


class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter a company name: ");
        string company = Console.ReadLine();

        Console.Write("Please enter a company address: ");
        string address = Console.ReadLine();

        Console.Write("Please enter a phone number: ");
        string phone = Console.ReadLine();

        Console.Write("Please enter a fax number: ");
        string fax = Console.ReadLine();

        Console.Write("Please enter a webste address: ");
        string website = Console.ReadLine();

        Console.Write("Please enter manager's first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Please enter manager's last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Please enter manager's age: ");
        string age = Console.ReadLine();

        Console.Write("Please enter manager's phone: ");
        string privatePhone = Console.ReadLine();

        Console.Clear();

        Console.WriteLine(company);
        Console.WriteLine("Adress: {0}", address);
        Console.WriteLine("Tel. {0}", phone);
        Console.WriteLine("Fax: {0}", fax);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", firstName + " " + lastName, age, privatePhone);


    }
}

