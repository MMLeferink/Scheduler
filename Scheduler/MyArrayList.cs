using System.Linq;


namespace Scheduler
{
    public class MyArrayList<T> : IMyArrayList<T>
    {
        private T[] data;
        private int size;

        /// <summary>
        /// Constructs an ArrayList instance
        /// </summary>
        public MyArrayList()
        {
            size = 0;
            data = new T[20];
        }

        /// <summary>
        /// Add an item to the ArrayList
        /// </summary>
        /// <complexity>O(1)</complexity>
        /// <param name="n">Item to add</param>
        public void Add(T n)
        {
            if (data.Length == size)
                throw new MyArrayListFullException();
            data[size] = n;
            size++;
        }

        /// <summary>
        /// Gets an item from the ArrayList
        /// </summary>
        /// <complexity>O(1)</complexity>
        /// <param name="index">Index to get item from</param>
        /// <returns>The requested item</returns>
        public T Get(int index)
        {
            if (index >= size || index < 0 || size == 0)
                throw new MyArrayListIndexOutOfRangeException();
            return data[index];
        }

        /// <summary>
        /// Sets value of a specified index
        /// </summary>
        /// <complexity>O(1)</complexity>
        /// <param name="index">Index to set value on</param>
        /// <param name="n">Value to set</param>
        public void Set(int index, T n)
        {
            if (index >= size || index < 0 || size == 0)
                throw new MyArrayListIndexOutOfRangeException();
            data[index] = n;
        }

        /// <summary>
        /// Get the max amount of items
        /// </summary>
        /// <complexity>O(1)</complexity>
        /// <returns>The capacity of the ArrayList</returns>
        public int Capacity()
        {
            return data.Length;
        }

        /// <summary>
        /// Gets the current size of the ArrayList
        /// </summary>
        /// <complexity>O(1)</complexity>
        /// <returns>Size of the ArrayList</returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// Remove the last item
        /// </summary>
        public void RemoveItem()
        {
            if (size > 0)
                size--;
        }

        /// <summary>
        /// Clears the ArrayList
        /// </summary>
        /// <complexity>O(1)</complexity>
        public void Clear()
        {
            size = 0;
            data = new T[data.Length];
        }

        /// <summary>
        /// Count amount of occurrences of a value
        /// </summary>
        /// <complexity>O(N)</complexity>
        /// <param name="n">Value to check occurrences for</param>
        /// <returns>Amount of occurrences</returns>
        public int CountOccurences(T n)
        {
            return data.Count(val => val.Equals(n));
        }

        /// <summary>
        /// Creates a string instance for the ArrayList
        /// </summary>
        /// <complexity>O(N)</complexity>
        /// <returns>The created string</returns>
        public override string ToString()
        {
            if (size <= 0)
                return "";
            string stringValue = "";

            for (int i = 0; i < size; i++)
            {
                stringValue += $"{data[i].ToString()},";
            }
            // Strip the last comma
            stringValue = stringValue.Remove(stringValue.Length - 1);

            return stringValue;
        }
    }
}