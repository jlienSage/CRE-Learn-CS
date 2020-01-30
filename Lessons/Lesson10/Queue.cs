
using System;
using System.Collections.Generic;
namespace DataStructure
{
    public partial class Lesson10
    {
        public static void Queue()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Queue Example: ");
            Console.WriteLine("----------------------------- ");
            //Homework: Create a Queue and fill in the lines. See below for more details.

            // Create a Queue
            var queue = new Queue<string>();

            // Add all the students name who are in the class in the queue one by one
            queue.Enqueue("Rich");
            queue.Enqueue("Greg");
            queue.Enqueue("Chris");
            queue.Enqueue("Lisa");

            // Add 'Aman' and 'John' in the Queue
            queue.Enqueue("Aman");
            queue.Enqueue("John");

            // remove only 'Aman' from the queue and maintain the order of the queue. Write your logic and display queue
            var otherQueue = new Queue<string>();
            while(queue.TryDequeue(out var name))
            {
                if(name != "Aman")
                    otherQueue.Enqueue(name);
            }

            while(otherQueue.TryDequeue(out var name))
            {
                queue.Enqueue(name);
            }

            while(queue.TryDequeue(out var name))
            {
                Console.WriteLine(name);
            }
        }
    }
}