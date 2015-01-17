//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;


class BankAccountData
{
    static void Main()
    {
        string firstName = "Jane";
        string middleName = "Mary";
        string lastName = "Doe";
        object holderName = firstName + " " + middleName + " " + lastName;
        decimal balance = 20006.98M;
        string bankName = "New bank";
        string iban = "GB29NWBK60161331926819";
        ulong CreditCardNumber1 = 371449635398431;
        ulong CreditCardNumber2 = 36438936438936;
        ulong CreditCardNumber3 = 5500005555555559;
        Console.WriteLine(
            "Account holder: " + holderName
            + "\nBalance: " + balance
            + "\nBank: " + bankName
            + "\nIBAN: " + iban
            + "\nFist Credit Card: " + CreditCardNumber1
            + "\nSecond Credit Card: " + CreditCardNumber2
            + "\nThird Credit Card: " + CreditCardNumber3);
    }
}

