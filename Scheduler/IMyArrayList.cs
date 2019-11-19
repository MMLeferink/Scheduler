﻿using System;

namespace Scheduler
{
    /// <summary>
    /// Interface for MyArrayList class
    /// </summary>
    /// <typeparam name="T">Type of the ArrayList data</typeparam>
    public interface IMyArrayList<T>
    {
        // Add an element to the end of the list (as long
        // as there is still capacity)
        void Add(T n);

        // Get the value from an index
        T Get(int index);

        // Set the value at a certain index
        void Set(int index, T n);

        // Returns the capacity of the list
        int Capacity();

        // Returns the size of the list
        int Size();

        // Clears the list
        void Clear();

        // Count the number of occurences in the list of a number
        int CountOccurences(T n);
    }
    /// <summary>
    /// Exception to throw when out of range index is requested
    /// </summary>
    public class MyArrayListIndexOutOfRangeException : Exception { }
    /// <summary>
    /// Exception to throw when the ArrayList has reached it's capacity
    /// </summary>
    public class MyArrayListFullException : Exception { }
}