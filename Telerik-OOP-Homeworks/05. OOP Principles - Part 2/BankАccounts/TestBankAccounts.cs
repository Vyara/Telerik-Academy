//Problem 2. Bank accounts

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

namespace BankАccounts
{
    using System;

    class TestBankAccounts
    {
        static void Main()
        {
            //creates a bank
            var bank = new Bank();

            //adds accounts
            bank.AddAccount(new Deposit(new Individual("Isaac Newton"), 200, 0.02M));
            bank.AddAccount(new Deposit(new Company("Aperture Science"), 2000, 0.04M));
            bank.AddAccount(new Loan(new Individual("Charles Darwin"), 450, 0.05M));
            bank.AddAccount(new Loan(new Company("Black Mesa"), 10000, 0.03M));
            bank.AddAccount(new Mortgage(new Individual("Paul Dirac"), 300, 0.08M));
            bank.AddAccount(new Mortgage(new Company("Umbrella Corp."), 500000, 0.05M));

            //calculates interest amount for each account and prints it(uses randomly generated amount of months)
            var monthsGenerator = new Random();
            var count = 1;
            foreach (var account in bank.Accounts)
            {
                var months = monthsGenerator.Next(1, 36);
                Console.WriteLine("Account: {0}, Type: {1}", count, account.GetType().Name);
                Console.WriteLine(account.ToString());
                Console.WriteLine("Interest rate for {0} months: {1}", months, account.CalculateInterestAmount(months));
                Console.WriteLine(new string('-', 30));
                count++;
            }

        }
    }
}
