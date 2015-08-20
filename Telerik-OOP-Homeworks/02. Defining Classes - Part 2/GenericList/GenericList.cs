//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.
//Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//You may need to add a generic constraints for the type T.

namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        //fields
        private T[] elements;
        private int index;

        //constructors
        public GenericList(int length)
        {
            this.elements = new T[length];
            this.index = 0;
            this.Length = length;
        }

        //properties
        public int Length { get;  private set; }

        public int Count
        {
            get
            {
                return this.index;
            }

            private set
            {
                this.index = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");

                }

                return this.elements[index];
            }

            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.elements[index] = value;
            }
        }



        //methods
        public void Add(T element)
        {

            if (this.index == this.elements.Length)
            {
                IncreaseSize();
            }

            this.elements[this.index] = element;
            this.index++;

        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= this.elements.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = index + 1; i < this.Count; i++)
            {
                this.elements[i - 1] = this.elements[i];
            }

            this.elements[this.Count - 2] = default(T);

        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index >= this.elements.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (this.Count == this.elements.Length)
            {
                IncreaseSize();
            }

            for (int i = this.Count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
        }

        public T ElementAt(int index)
        {
            if (index < 0 || index >= this.elements.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return this.elements[index];
        }

        public int IndexOf(T element)
        {
            int count = 0;
            int index = -1; //returns -1 if there's no such element

            while (count < this.elements.Length - 1)
            {
                if (this.elements[count].Equals(element))
                {
                    index = count;
                    break;
                }
                count++;
            }

            return count;
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.elements[i] = default(T);
            }
        }

        private void IncreaseSize()
        {
            if (this.elements.Length == 0)
            {
                this.Length = 2;
            }

            else
            {
                this.Length = 2 * this.Length;
            }
            Array.Resize(ref this.elements, this.Length);
        }

        public T Min()
        {
            var min = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(min) <= 0)
                {
                    min = elements[i];
                }
            }

            return min;
        }


        public T Max()
        {
            var max = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            var list = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                list.AppendLine(String.Format("{0, -5}{1}", String.Format("[{0}]", i), this.elements[i]));
            }

            return list.ToString().Trim();
        }

    }
}
