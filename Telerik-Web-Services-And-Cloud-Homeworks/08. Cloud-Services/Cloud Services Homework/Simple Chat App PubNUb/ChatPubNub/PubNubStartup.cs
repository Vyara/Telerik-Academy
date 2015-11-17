namespace ChatPubNub
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
 
    public class PubNubStartup
    {
       public static void Main()
        {
            // Start the HTML5 Pubnub client
            Process.Start(@"..\..\index.html");

            System.Threading.Thread.Sleep(2000);

            PubnubAPI pubnub = new PubnubAPI(
                "pub-c-35648aec-f497-4d5b-ab3e-8d621ba3794c",               // PUBLISH_KEY
                "sub-c-fb346fbe-8d19-11e5-a7e4-0619f8945a4f",               // SUBSCRIBE_KEY
                "sec-c-M2JmNWIwODMtNDNhYi00MjBlLWI2ZTYtZjExNjA1OTU4ZDBj",   // SECRET_KEY
                true                                                        // SSL_ON?
            );

            string channel = "simple chat channel";

            // Publish a sample message to Pubnub
            List<object> publishResult = pubnub.Publish(channel, "Hello there!");

            Console.WriteLine(
                "Publish Success: " + publishResult[0] + "\n" +
                "Publish Info: " + publishResult[1]
            );

            // Show PubNub server time
            object serverTime = pubnub.Time();
            Console.WriteLine("Server Time: " + serverTime);

            // Subscribe for receiving messages (in a background task to avoid blocking)
            var task = new System.Threading.Tasks.Task(
                () =>
                pubnub.Subscribe(
                    channel,
                    delegate (object message)
                    {
                        Console.WriteLine("Received Message -> '" + message + "'");
                        return true;
                    }

                )
            );

            task.Start();

            // Read messages from the console and publish them to Pubnub
            while (true)
            {
                Console.Write("Enter a message to be sent to Pubnub: ");
                var message = Console.ReadLine();
                pubnub.Publish(channel, message);
                Console.WriteLine("Message {0} sent.", message);
            }
        }
    }
}
