using System;

namespace Scheduler
{
    /// <summary>
    /// Priority levels in schedule
    /// </summary>
    public enum Priority
    {
        High = 0,
        Medium = 1,
        Low = 2
    }

    /// <summary>
    /// Interface for scheduler class
    /// </summary>
    /// <typeparam name="T">Type of the schedule data</typeparam>
    interface IScheduler<T>
    {
        void Enqueue(Priority priority, T Data);
        T Dequeue();
    }

    /// <summary>
    /// Exception to throw when all queues are empty
    /// </summary>
    public class AllQueuesEmptyException : Exception { }
}