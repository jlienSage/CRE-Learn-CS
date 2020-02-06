
using System;
using System.Collections.Generic;

namespace DataStructure
{
    public partial class Lesson10
    {
        public static void HashSet()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("HashSet Example: ");
            Console.WriteLine("----------------------------- ");
            // Creating a HashSet of even numbers from 10 to 40 and display using foreach or for loop
            HashSet<int> evenNumbers = new HashSet<int>();

            for (int i = 5; i < 21; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            //Display items in HashSet
            void DisplaySet(HashSet<int> set)
            {
                Console.Write("{");
                foreach (int i in set)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }
        }
    }
}
