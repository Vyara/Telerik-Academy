//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:


using System;



class IsoscelesTriangle
{
    static void Main()
    {
        string copyRight = "\u00a9";
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("   " + copyRight + " ");
        Console.WriteLine("   ");
        Console.WriteLine("  " + copyRight + " " + copyRight);
        Console.WriteLine("   ");
        Console.WriteLine(" " + copyRight + "   " + copyRight);
        Console.WriteLine("   ");
        Console.WriteLine(copyRight + " " + copyRight + " " + copyRight +  " " + copyRight);
    }
}
