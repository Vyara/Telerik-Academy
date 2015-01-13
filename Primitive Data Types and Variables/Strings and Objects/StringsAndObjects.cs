//Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;



class StringsAndObjects
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object helloAndworld = helloString + " " + worldString;
        string objectString = (string)helloAndworld;
        Console.WriteLine("This string says \"Hello\": {0}", helloString);
        Console.WriteLine("This string says \"World\": {0}", worldString);
        Console.WriteLine("This object says \"Hello World\": {0}", helloAndworld);
        Console.WriteLine("This string also says \"Hello World\": {0}", objectString);
    }
}

