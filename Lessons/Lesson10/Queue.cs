
using System;
using System.Collections;

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

            // C# program to illustrate queue 

            {
                Queue coWorker_queue = new Queue();
                // Add all the students name who are in the class in the queue one by one
                // Adding elements in Queue 
                // Using Enqueue() method 
                coWorker_queue.Enqueue("Rich");
                coWorker_queue.Enqueue("Greg");
                coWorker_queue.Enqueue("Lisa");
                coWorker_queue.Enqueue("Chris");

                // Add 'Aman' and 'John' in the Queue
                coWorker_queue.Enqueue("John");
                coWorker_queue.Enqueue("Aman");

                // Accessing the elements 
                // of my_queue Queue 
                // Using foreach loop 
                foreach (var ele in coWorker_queue)
                {
                    Console.WriteLine(ele);
                  //  coWorker_queue.Dequeue("Aman");
                }
                // remove only 'Aman' from the queue and maintain the order of the queue. Write your logic and display queue   } 
            }

        }
    }
}