using System;
using System.Collections.Generic;

namespace DataStructure
{
    public  partial class Lesson10
    {
        public static void List()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("List Example: ");
            Console.WriteLine("----------------------------- ");

            // Creating an List<T> of Integers 
            List<int> firstlist = new List<int>();

            // Adding elements to List 
            firstlist.Add(17);
            firstlist.Add(19);
            firstlist.Add(21);
            firstlist.Add(9);
            firstlist.Add(75);
            firstlist.Add(19);
            firstlist.Add(73);

            Console.WriteLine("Elements Present in List:\n");

            int p = 0;

            // Displaying the elements of List 
            foreach (int k in firstlist)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine(" ");

            // removing the element at index 3 
            Console.WriteLine("Removing the element at index 3\n");

            // 9 will remove from the List 
            // and 75 will come at index 3 
            firstlist.RemoveAt(3);

            int p1 = 0;

            // Displaying the elements of List 
            foreach (int n in firstlist)
            {
                Console.Write("At Position {0}: ", p1);
                Console.WriteLine(n);
                p1++;
            }
        }
    }
}