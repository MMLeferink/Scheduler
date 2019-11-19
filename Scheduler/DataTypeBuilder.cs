namespace Scheduler
{
    public class DataTypeBuilder
    {
        /// <summary>
        /// Create a MyQueue instance for unit testing
        /// </summary>
        /// <returns>Instance of MyQueue</returns>
        public static IMyQueue<string> CreateMyQueue()
        {
            return new MyQueue<string>();
        }

        /// <summary>
        /// Create a MyArrayList instance for unit testing
        /// </summary>
        /// <returns>Instance of MyArrayList</returns>
        public static IMyArrayList<int> CreateMyArrayList()
        {
            return new MyArrayList<int>();
        }
    }
}