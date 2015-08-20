
namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    class TimerTests
    {
        static void Main()
        {
            //adding methods to delegate and creating Timer objects that use delegates
            TimerEvent firstEvent = MessageEveryNSeconds;
            Timer firstTimer = new Timer(5, firstEvent);

            TimerEvent secondEvent = MessageEveryNSeconds;
            Timer secondTimer = new Timer(10, secondEvent);

            //executing methods in delegates
            Thread firstThread = new Thread(firstTimer.Execute);
            firstThread.Start();

            Thread secondThread = new Thread(secondTimer.Execute);
            secondThread.Start();


        }

        //test methods
        private static void MessageEveryNSeconds(int period)
        {
            Console.WriteLine("Message at every {0}th miliseconds.", period);
        }

    }
}
