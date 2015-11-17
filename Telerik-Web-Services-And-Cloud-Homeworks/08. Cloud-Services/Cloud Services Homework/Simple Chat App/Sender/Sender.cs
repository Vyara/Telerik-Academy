namespace Sender
{
    using System;
    using IronMQ;

    public class Sender
    {
        public static void Main()
        {
            var client = new Client("564a509a9195a800070000cb", "SCdibPtAnk5NlXlkIvnq");
            var queue = client.Queue("My Simple chat");
            Console.Write("Please enter a message: ");
            while (true)
            {
                string msg = Console.ReadLine();
                queue.Push(msg);
                Console.WriteLine("Message sent. Please start the receiver program to see it.");
            }
        }
    }
}
