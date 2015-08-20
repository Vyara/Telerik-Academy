//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _64BitArray
{
    using System;
    using System.Collections.Generic;


    public class BitArray64 : IEnumerable<int>
    {
        //fields
        
        //constructors
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        //properties
        public ulong Number { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return (byte)((this.Number >> index) & 1);
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                if (value > 1 || value < 0)
                {
                    throw new ArgumentException("Value must be 0 or 1");
                }

                if (value == 0)
                {
                    this.Number = this.Number & (ulong)(~(1 << index));
                }
                else
                {
                    this.Number = this.Number | (ulong)(1 << index);
                }
            }
        }

        //methods

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var number = obj as BitArray64;

            if (number == null)
            {
                return false;
            }

            return this.Number == number.Number;
        }

        public static bool operator == (BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }

        public static bool operator != (BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return !BitArray64.Equals(firstNumber, secondNumber);
        }

        public override int GetHashCode()
        {
            //will implement it with 2 prime numbers instead of using XOR
            int hash = 17;
            hash = hash * 23 + this.Number.GetHashCode();
            return hash;
        }
    }
}
