// Main Method 
using System;
using System.Collections.Generic;

namespace DataStructure
{
    public partial class Lesson10
    {
        public static void LinkedList()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("LinkedList Example: ");
            Console.WriteLine("----------------------------- ");
            
            // Creating a linkedlist 
            // Using LinkedList class 
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList 
            // Using AddLast() method 
            my_list.AddLast("John");
            my_list.AddLast("Greg");
            my_list.AddLast("Lisa");
            my_list.AddLast("Rich");
            my_list.AddLast("Chris");
            my_list.AddLast("Aman");

            Console.WriteLine("Best Workers of Sage:");

            // Accessing the elements of  
            // LinkedList Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            my_list.Remove(my_list.First);
            //my_list.Remove(my_list.Last); 
            // or you can do 
            my_list.RemoveLast();

            // Accessing the elements of  
            // LinkedList Using foreach loop 
            Console.WriteLine(" ");
            Console.WriteLine("After removing");
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(" ");

            // Check if the given element 
            // is available or not 
            if (my_list.Contains("Aman") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }
        }
    }
}