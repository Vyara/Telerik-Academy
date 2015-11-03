namespace LinkedListImplementation
{
    using System;

    /// <summary>
    /// Implement the data structure linked list.
    /// Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
    /// Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var testList = new ImplementedLinkedList<string>();
            testList.Add("FirstItem");
            testList.Add("SecondItem");
            testList.Add("ThirdItem");
            testList.Add("FourthItem");

            foreach (var element in testList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
