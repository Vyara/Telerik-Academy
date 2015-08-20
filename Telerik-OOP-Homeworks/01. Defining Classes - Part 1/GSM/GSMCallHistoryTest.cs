//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

using System;



class GSMCallHistoryTest
{
    //method for testing the calls
    public static void CallHistoryTest()
    {
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Phone calls test");

        //creates an instance of the GSM class
        var phone = new GSM("Lumia 1920", "Nokia");

        //adds calls
        phone.AddACall(new Call("0555 555 555", 120));
        phone.AddACall(new Call("0999 999 999", 153));
        phone.AddACall(new Call("0888 888 888", 305));

        //displays information about calls
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Calls added.");
        Console.WriteLine("Calls: ");
        foreach (var call in phone.CallHistory)
        {
            Console.WriteLine(call.ToString());
            Console.WriteLine();
        }

        //total price at 0.37 price per minute
        Console.WriteLine(new string('-', 30));
        var price = phone.CallPrice(0.37M);
        Console.WriteLine("Total price of the calls: {0:F2}", price);

        //finding longest call
        ulong longestCall = 0;
        foreach (var call in phone.CallHistory)
        {
            if (call.Duration > longestCall)
            {
                longestCall = call.Duration;
            }
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Longest call: {0} seconds", longestCall);

        //removing longest call
        var longest = new Call("000", 000);
        foreach (var call in phone.CallHistory)
        {
            if (call.Duration == longestCall)
            {
                longest = call;
            }
        }
        phone.DeleteACall(longest);

        //calculate total price again
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("After removing the longest call: ");
        price = phone.CallPrice(0.37M);
        Console.WriteLine("Total price of the calls: {0:F2}", price);

        //clear call history
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Clearing call history...");
        phone.ClearCallHistory();

        //print call history
        Console.WriteLine("Call history elements: {0}", phone.CallHistory.Count);
    }

}

