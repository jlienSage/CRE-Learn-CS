
using System;
using System.Collections;       //rich added this

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
            Queue myQ = new Queue();
            Queue myQ2 = new Queue();



            // Add all the students name who are in the class in the queue one by one
            myQ.Enqueue ("Rich");
            myQ.Enqueue ("Chris");
            myQ.Enqueue ("Greg");
            myQ.Enqueue ("Lisa");

            // Add 'Aman' and 'John' in the Queue
            myQ.Enqueue ("Aman");
            myQ.Enqueue ("John");


            // remove only 'Aman' from the queue and maintain the order of the queue. Write your logic and display queue
            Console.WriteLine ("Queue before removing anyone");
            foreach (string str in myQ)
            {
                Console.WriteLine($"Name: {str}");
                if (string.Equals(str, "Aman"))
                {
                    Console.WriteLine("*** Found Aman ***");
                }   
                else
                {
                    myQ2.Enqueue (str);
                }
            }

            Console.WriteLine ("\nQueue after removing someone");
            //print final queue
            foreach (string str in myQ2)
            {
                Console.WriteLine($"Name: {str}");
            }

        }
    }
}