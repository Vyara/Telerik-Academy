namespace GenericList
{
    using System;

    class GenericListTest
    {
        static void Main()
        {
            var intList = new GenericList<int>(2);

            Console.WriteLine("Creating an int generic list of length 2");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine("Length: {0}", intList.Length);

            intList.Add(3);
            intList.Add(5);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Adding 2 elements.");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine("Length: {0}", intList.Length);
            Console.WriteLine();
            Console.WriteLine("Elements:");
            Console.WriteLine(intList.ToString());

            intList.Add(7);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Adding another element.");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine("Length: {0}", intList.Length);
            Console.WriteLine();
            Console.WriteLine("Elements:");
            Console.WriteLine(intList.ToString());

            intList.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Clearing list.");

            intList.InsertAt(0, 2);
            intList.InsertAt(0, 2);
            intList.InsertAt(1, 3);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Inserting elements.");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine("Length: {0}", intList.Length);
            Console.WriteLine();
            Console.WriteLine("Elements:");
            Console.WriteLine(intList.ToString());

            intList.RemoveAtIndex(0);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Removing an element.");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine("Length: {0}", intList.Length);
            Console.WriteLine();
            Console.WriteLine("Elements:");
            Console.WriteLine(intList.ToString());

            var element  = intList.ElementAt(0);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Element at index 0 is {0}.", element);

            element = intList.IndexOf(3);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("The index of element 3 is {0}.", element);

            var max = intList.Max();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("The max element is {0}.", max);

            var min = intList.Min();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("The min element is {0}.", min);

        }
    }
}