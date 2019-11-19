namespace Scheduler
{
    public class Scheduler<T> : IScheduler<T>
    {
        // Insert data members here
        public MyQueue<T>[] scheduler;

        /// <summary>
        /// Constructs a new scheduler instance
        /// </summary>
        public Scheduler()
        {
            scheduler = new MyQueue<T>[3];
            scheduler[0] = new MyQueue<T>();
            scheduler[1] = new MyQueue<T>();
            scheduler[2] = new MyQueue<T>();
        }

        /// <summary>
        /// Enqueue an item in the specified queue
        /// </summary>
        /// <param name="priority">Queue to add item to</param>
        /// <param name="Data">Data of the item</param>
        public void Enqueue(Priority priority, T Data)
        {
            switch (priority)
            {
                case Priority.High:
                    scheduler[0].Enqueue(Data);
                    break;
                case Priority.Medium:
                    scheduler[1].Enqueue(Data);
                    break;
                case Priority.Low:
                    scheduler[2].Enqueue(Data);
                    break;
            }
        }
        /// <summary>
        /// Dequeue an item from the highest priority
        /// </summary>
        /// <returns>The dequeued item</returns>
        public T Dequeue()
        {
            T data;

            // Dequeue the highest priority item
            if (!scheduler[0].IsEmpty())
                data = scheduler[0].Dequeue();
            else if (!scheduler[1].IsEmpty())
                data = scheduler[1].Dequeue();
            else if (!scheduler[2].IsEmpty())
                data = scheduler[2].Dequeue();
            else
                throw new AllQueuesEmptyException();

            // Move items to a more important queue
            if (!scheduler[1].IsEmpty())
                scheduler[0].Enqueue(scheduler[1].Dequeue());
            if (!scheduler[2].IsEmpty())
                scheduler[1].Enqueue(scheduler[2].Dequeue());

            // Return the dequeued item
            return data;
        }

        /// <summary>
        /// Creates a string instance for the scheduler
        /// </summary>
        /// <returns>The created string</returns>
        public override string ToString()
        {
            string str = "{";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    str += "High:[";
                if (i == 1)
                    str += "Medium:[";
                if (i == 2)
                    str += "Low:[";

                str += scheduler[i].ToString();

                if (i == 2)
                    str += "]}";
                else
                    str += "],";
            }

            return str;
        }
    }
}
