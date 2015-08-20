//Problem 3. Range Exceptions

//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace RangeExceptions
{
    using System;
    using System.Globalization;

    class TestRangeExceptions
    {
        static void Main()
        {
            //testing with numbers
            Console.Write("Please enter a number: ");
            var number = decimal.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<decimal>("The number should be between 1 and 100.", 1, 100);
            }

            //testing with DateTime
            Console.WriteLine(new string('-', 30));
            Console.Write("Please enter a date in the format dd.MM.yyyy: ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var startingPoint = new DateTime(1980, 01, 01);
            var endingPoint = new DateTime(2013, 12, 31);

            if (date < startingPoint || date > endingPoint)
            {
                throw new InvalidRangeException<DateTime>("Date must be between 01.01.1980 and 31.12.2013.", startingPoint, endingPoint);
            }


        }
    }
}
