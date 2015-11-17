namespace Receiver
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using IronMQ;

    public class Receiver
    {
        public static void Main()
        {
            var client = new Client("564a509a9195a800070000cb", "SCdibPtAnk5NlXlkIvnq");
            var queue = client.Queue("My Simple chat");
            Console.WriteLine("Listening for new messages:");
            while (true)
            {
                var message = queue.Get();
                if (message != null)
                {
                    var ip = Dns.GetHostAddresses(Dns.GetHostName()).Where(address => address.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault();

                    Console.WriteLine("{0}: {1}", ip, message.Body);
                    queue.DeleteMessage(message);
                }

                Thread.Sleep(100);
            }
        }
    }
}
