using System;

namespace Scheduler
{
    /// <summary>
    /// Interface for MyQueue class
    /// </summary>
    /// <typeparam name="T">Type of the queue data</typeparam>
    public interface IMyQueue<T>
    {
        bool IsEmpty();
        void Enqueue(T data);
        T GetFront();
        T Dequeue();
        void Clear();
    }

    /// <summary>
    /// Exception to throw when queue is empty
    /// </summary>
    public class MyQueueEmptyException : Exception { }
}