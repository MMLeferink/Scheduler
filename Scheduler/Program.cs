using System;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scheduler instance
            Scheduler<int> scheduler = new Scheduler<int>();

            // Enqueue 1 into low
            Console.WriteLine("Enqueue: Low, 1");
            scheduler.Enqueue(Priority.Low, 1);
            Console.WriteLine($"Result: {scheduler}\n");

            // Enqueue 2 into low
            Console.WriteLine("Enqueue: Low, 2");
            scheduler.Enqueue(Priority.Low, 2);
            Console.WriteLine($"Result: {scheduler}\n");

            // Enqueue 3 into low
            Console.WriteLine("Enqueue: Low, 3");
            scheduler.Enqueue(Priority.Low, 3);
            Console.WriteLine($"Result: {scheduler}\n");

            // Enqueue 100 into high
            Console.WriteLine("Enqueue: High, 100");
            scheduler.Enqueue(Priority.High, 100);
            Console.WriteLine($"Result: {scheduler}\n");

            // Dequeue an item
            Console.WriteLine("Dequeue");
            scheduler.Dequeue();
            Console.WriteLine($"Result: {scheduler}\n");

            // Enqueue 101 into high
            Console.WriteLine("Enqueue: High, 101");
            scheduler.Enqueue(Priority.High, 101);
            Console.WriteLine($"Result: {scheduler}\n");

            // Dequeue an item
            Console.WriteLine("Dequeue");
            scheduler.Dequeue();
            Console.WriteLine($"Result: {scheduler}\n");

            // Show final schedule
            Console.WriteLine($"\nFinal: {scheduler}");
        }
    }
}
