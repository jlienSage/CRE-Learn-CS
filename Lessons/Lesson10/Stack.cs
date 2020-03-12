
using System;
using System.Collections;
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


            // Add 'Aman' and 'John' in the Stack
            
            myStack.Push("Aman");
            myStack.Push("John");


            // Add all the students name who are in the class in the Stack one by one

            myStack.Push("Lisa");
            myStack.Push("Rich");
            myStack.Push("Chris");
            myStack.Push("Greg");

             Console.Write("Total number of people in the Stack are : "); 
  
        Console.WriteLine(myStack.Count); 


            // remove only 'Aman' from the stack and maintain the order of the stack. Write your logic and display stack

            myStack.Clear();
            myStack.Push("John");
            myStack.Push("Lisa");
            myStack.Push("Rich");
            myStack.Push("Chris");
            myStack.Push("Greg");
            myStack.Push("Aman");

            myStack.Pop();

                Console.Write("Total number of people in the Stack are : "); 
  
        Console.WriteLine(myStack.Count); 

        }
    }
}