//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Timer
{
    using System;
    using System.Threading;

    public delegate void TimerEvent(int param);
    class Timer
    {
        //fields
        private TimerEvent timerEvent;
        private int miliSeconds;
        private int ticks;

        //constructors
        public Timer(int seconds, TimerEvent timerEvent)
        {
            this.Period = seconds;
            this.TimerEvent = timerEvent;
        }

        public Timer(int ticks, int seconds, TimerEvent timerEvent)
            :this(seconds, timerEvent)
        {
            this.Ticks = ticks;

        }

        //properties
        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ticks value must be greater than zero.");
                }

                this.ticks = value;
            }
        }

        public int Period
        {
            get
            {
                return this.miliSeconds;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ticks value must be greater than or equal to zero.");
                }

                this.miliSeconds = value * 1000;
            }

        }

        public TimerEvent TimerEvent { get; set; }


        //methods
        public void Execute()
        {
            while (this.Ticks < this.Period)
            {
                Thread.Sleep(this.Period);
                this.Ticks++;
                this.TimerEvent(this.Period);
            }
        }
    }
}
