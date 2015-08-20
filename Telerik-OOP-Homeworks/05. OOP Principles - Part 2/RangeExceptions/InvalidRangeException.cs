namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable
    {
        //fields


        //constructors
        public InvalidRangeException(string message, T startingPoint, T endingPoint, Exception exception)
            : base(message, exception)
        {
            this.StartingPoint = startingPoint;
            this.EndingPoint = endingPoint;
        }

        public InvalidRangeException(string message, T startingPoint, T endingPoint)
            : this(message, startingPoint, endingPoint, null)
        {

        }

        //properties
        public T StartingPoint { get; private set; }


        public T EndingPoint { get; private set; }

        //methods
    }
}
