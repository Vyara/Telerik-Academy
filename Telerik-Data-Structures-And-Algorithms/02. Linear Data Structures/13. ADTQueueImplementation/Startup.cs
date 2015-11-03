namespace ADTQueueImplementation
{
    using System;

    /// <summary>
    /// Implement the ADT queue as dynamic linked list.
    /// Use generics(LinkedQueue<T>) to allow storing different data types in the queue.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var testQeue = new LinkedQueue<int>();
            testQeue.Enqueue(1);
            testQeue.Enqueue(2);
            testQeue.Enqueue(3);

            while (testQeue.Count > 0)
            {
                Console.WriteLine(testQeue.Dequeue());
            }
        }
    }
}
