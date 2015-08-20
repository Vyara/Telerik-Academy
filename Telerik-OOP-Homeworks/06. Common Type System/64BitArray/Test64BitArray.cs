namespace _64BitArray
{
    using System;

    class Test64BitArray
    {
        static void Main()
        {
            //creating arrays
            BitArray64 firstBitArray = new BitArray64(27641465162362435);
            BitArray64 secondBitArray = new BitArray64(45765454765);

            //printing and comparing arrays
            Console.WriteLine("First array: ");
            Console.WriteLine(new string('-', 30));
            PrintArray(firstBitArray);
            Console.WriteLine("Value at index 5 is: {0}", firstBitArray[5]);
            Console.WriteLine("Hash Code: {0}", firstBitArray.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("Second array: ");
            Console.WriteLine(new string('-', 30));
            PrintArray(secondBitArray);
            Console.WriteLine("Value at index 9 is: {0}", secondBitArray[9]);
            Console.WriteLine("Hash Code: {0}", secondBitArray.GetHashCode());

            var areEqual = firstBitArray == secondBitArray;
            Console.WriteLine();
            Console.WriteLine("First Array  == Second Array? {0}", areEqual);
           

        }

        //method for printing arrays(using foreach)
        private static void PrintArray(BitArray64 array)
        {
            foreach (var value in array)
            {
                Console.Write(value);
            }
            Console.WriteLine();
        }
    }
}
