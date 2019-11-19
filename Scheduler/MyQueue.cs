namespace Scheduler
{
    public class MyQueue<T> : IMyQueue<T>
    {
        private MyArrayList<T> _list = new MyArrayList<T>();

        /// <summary>
        /// Checks if the queue is empty
        /// </summary>
        /// <returns>True if queue empty</returns>
        public bool IsEmpty()
        {
            return _list.Size() <= 0;
        }

        /// <summary>
        /// Enqueue an item
        /// </summary>
        /// <param name="data">Item to enqueue</param>
        public void Enqueue(T data)
        {
            _list.Add(data);
        }

        /// <summary>
        /// Gets the first item in the queue
        /// </summary>
        /// <returns>The first item in queue</returns>
        public T GetFront()
        {
            if (IsEmpty())
                throw new MyQueueEmptyException();
            return _list.Get(0);
        }

        /// <summary>
        /// Dequeue an item
        /// </summary>
        /// <returns>The dequeued item</returns>
        public T Dequeue()
        {
            var first = GetFront();
            if (_list.Size() == 1)
                Clear();
            for (var i = 0; i < _list.Size() - 1; i++)
            {
                _list.Set(i, _list.Get(i + 1));
            }

            _list.RemoveItem();
            return first;
        }

        /// <summary>
        /// Clear the queue
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        /// <summary>
        /// Creates a string instance for the queue
        /// </summary>
        /// <returns>The created string</returns>
        public override string ToString()
        {
            return _list.ToString();
        }
    }
}