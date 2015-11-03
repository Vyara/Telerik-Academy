namespace ADTStackImplementation
{
    using System;

    /// <summary>
    /// Implement the ADT stack as auto-resizable array.
    /// Resize the capacity on demand(when no space is available to add / insert a new element).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var testStack = new ImplementedStack<int>();
            for (int i = 0; i < 10; i++)
            {
                testStack.Push(i + 1);
            }

            Console.WriteLine("Size of stack: {0}", testStack.Count);
            Console.WriteLine(new string('-', 30));

            while (testStack.Count > 0)
            {
                Console.WriteLine("Current top element: {0}", testStack.Pop());
            }
        }
    }
}
