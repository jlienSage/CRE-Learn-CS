
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
            Queue<string> Q1 = new Queue<string>();
            Queue<string> Q2 = new Queue<string>();

            // Add all the students name who are in the class in the queue one by one
            Q1.Enqueue("Chris");
            Q1.Enqueue("Greg");
            Q1.Enqueue("Lisa");
            Q1.Enqueue("Rich");

            // Add 'Aman' and 'John' in the Queue
            Q1.Enqueue("Aman");
            Q1.Enqueue("John");

            //print the queue
            Console.WriteLine("Q1 elements are: ");
            PrintValues(Q1);

            // remove only 'Aman' from the queue and maintain the order of the queue. Write your logic and display queue

            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Dequeue Example: ");
            Console.WriteLine("----------------------------- ");

            string element1 = Q1.Peek();

            //Move the first element from Q to Q2 if it is not Aman

            int x = Q1.Count;
            int y = 1;

            while (y <= x)
            {
                if (element1 != "Aman")
                {
                    Q2.Enqueue(element1);
                    Q1.Dequeue();
                }
                else
                {
                    Q1.Dequeue();
                }
                if (Q1.Count > 0)
                {
                    element1 = Q1.Peek();
                }

                y++;
            }

            Console.WriteLine("Total number of elements in the Queue1 are : " + Q1.Count);
            Console.WriteLine("Total number of elements in the Queue2 are : " + Q2.Count);

            //PrintValues

            Console.WriteLine("----------------------------- ");
            Console.WriteLine("Q1 elements are: ");
            PrintValues(Q1);

            Console.WriteLine("----------------------------- ");
            Console.WriteLine("Q2 elements are: ");
            PrintValues(Q2);

            Console.WriteLine("----------------------------- ");



        }
    }
}