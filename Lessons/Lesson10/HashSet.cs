
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
            var even = new HashSet<int>();

            for(var i = 10; i <= 40; i += 2)
            {
                even.Add(i);
            }

            foreach(var number in even)
                Console.WriteLine(number);
        }
    }
}