using System;
using System.Collections;

namespace QueueExampleCS
{
    class QueueProgram
    {
        public static void Main()
        {
            Queue tasks = new Queue();
            tasks.Enqueue("Start");
            tasks.Enqueue("Learn");
            tasks.Enqueue("Practice");
            tasks.Enqueue("Complete");
            tasks.Enqueue("Submit");
            tasks.Enqueue(2024 + " Assignment");

            Console.WriteLine("Tasks Queue:");
            foreach (var task in tasks)
            {
                Console.Write(task + " -> ");
            }
            Console.WriteLine("Done");

            Console.WriteLine("\nProcessing tasks:");
            while (tasks.Count > 0)
            {
                Console.WriteLine("Processing: " + tasks.Dequeue());
            }
            
            Console.ReadKey();
        }
    }
}
