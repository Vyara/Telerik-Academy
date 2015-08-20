//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.


using System;




class Tests
{
    static void Main()
    {
        Console.WriteLine("GSM instances test");
        Console.WriteLine(new string('-', 30));
        //creates array with GSM instances
        var gsms = new GSM[] 
        {
            new GSM("Galaxy S3","Samsung"),
            new GSM("G2 Mini", "LG", 190, new Battery("2440 mAh", 700, 12, Battery.Type.LiIon), new Display(540, 960, 16000000), "Martin"),
            new GSM("Nexus 6", "Motorola", new Display(1440, 2560)),
            new GSM("One M9", "HTC", 500, new Battery("Non-removable 2840 mAh", 391, 25), new Display(1080, 1920, 160000000))
        };

        //displays the information about the GSMs in the array
        foreach (var gsm in gsms)
        {
            Console.WriteLine(gsm.ToString());
        }

        //displays the information about the static property IPhone4S
        Console.WriteLine("Information about iPhone 4S: ");
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(GSM.IPhone4S);

        //tests calls
        GSMCallHistoryTest.CallHistoryTest();
    }

}

