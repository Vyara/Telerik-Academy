namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// We are given numbers N and M and the following operations:
    /// N = N+1
    /// N = N+2
    /// N = N*2
    /// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
    /// Hint: use a queue.
    /// Example: N = 5, M = 16
    /// Sequence: 5 → 7 → 8 → 16
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            PrintShortestSequenceOfOperations(5, 16);
        }

        private static void PrintShortestSequenceOfOperations(int startPoint, int endPoint)
        {
            var initialStart = startPoint;
            if (startPoint < 0 || startPoint >= endPoint)
            {
                Console.WriteLine(
                    "The starting point {0} should be a positive number and should be less than the ending point {1}",
                    startPoint, 
                    endPoint);
            }
            else
            {
                var numberSequence = new Queue<int>();
                numberSequence.Enqueue(startPoint);

                if (startPoint + 1 == endPoint)
                {
                    numberSequence.Enqueue(startPoint + 1);
                    Console.WriteLine(string.Join(" -> ", numberSequence));
                }
                else if (startPoint + 2 == endPoint)
                {
                    numberSequence.Enqueue(startPoint + 2);
                    Console.WriteLine(string.Join(" -> ", numberSequence));
                }
                else if (startPoint + 2 > startPoint * 2)
                {
                    startPoint += 2;
                    numberSequence.Enqueue(startPoint);
                }
                else if (startPoint * 2 > endPoint)
                {
                    while (startPoint + 2 <= endPoint)
                    {
                        numberSequence.Enqueue(startPoint += 2);
                    }

                    Console.WriteLine(string.Join(" -> ", numberSequence));
                }
                else
                {
                    while (startPoint * 2 < endPoint / 2)
                    {
                        numberSequence.Enqueue(startPoint *= 2);
                    }

                    while (startPoint + 2 <= endPoint / 2)
                    {
                        numberSequence.Enqueue(startPoint += 2);
                    }

                    while (startPoint + 1 <= endPoint / 2)
                    {
                        numberSequence.Enqueue(startPoint += 1);
                    }

                    numberSequence.Enqueue(startPoint *= 2);

                    if (startPoint != endPoint)
                    {
                        numberSequence.Enqueue(startPoint += 1);
                    }

                    Console.WriteLine("N = {0}, M = {1}", initialStart, endPoint);
                    Console.WriteLine("Sequence: {0}", string.Join(" -> ", numberSequence));
                }
            }
        }
    }
}
