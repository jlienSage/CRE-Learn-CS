
using System;
using System.Collections;       //rich added this

namespace DataStructure
{
    public partial class Lesson10
    {
        public static void Stack()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Stack Example: ");
            Console.WriteLine("----------------------------- ");
            //Homework: Create a Stack and fill in the lines as commented. See below for more details.

            // Create a Stack
            Stack myStack = new Stack();
            Stack myStack2 = new Stack();

            // Add 'Aman' and 'John' in the Stack
            myStack.Push("Aman");
            myStack.Push("John");

            // Add all the students name who are in the class in the Stack one by one
            myStack.Push("Lisa");
            myStack.Push("Greg");
            myStack.Push("Chris");
            myStack.Push("Rich");




            // remove only 'Aman' from the stack and maintain the order of the stack. Write your logic and display stack
            Console.WriteLine("\nStack of persons while searching for someone");
            foreach (string person in myStack)
            {
                Console.WriteLine($"Person: {person}");
                if (string.Equals(person, "Aman"))
                {
                    Console.WriteLine("*** Found Aman ***");
                }
                else
                {
                    myStack2.Push (person);
                }
            }

            Console.WriteLine("\nStack of persons after removing someone");
            foreach (string person in myStack2)
            {
                Console.WriteLine($"Person: {person}");
            }

        }
    }
}