
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

            Queue my_queue = new Queue();



            // Add all the students name who are in the class in the queue one by one

            my_queue.Enqueue("Lisa");
            my_queue.Enqueue("Rich");
            my_queue.Enqueue("Chris");
            my_queue.Enqueue("Greg");


            // Add 'Aman' and 'John' in the Queue

            my_queue.Enqueue("Aman");
            my_queue.Enqueue("John");


              Console.Write("Total number of people in the Queue are : "); 
  
        Console.WriteLine(my_queue.Count); 
            // remove only 'Aman' from the queue and maintain the order of the queue. Write your logic and display queue



        }
    }
}