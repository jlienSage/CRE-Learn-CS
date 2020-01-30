
using System;
using System.Collections.Generic;
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
            var stack = new Stack<string>();

            // Add 'Aman' and 'John' in the Stack
            stack.Push("Aman");
            stack.Push("John");

            // Add all the students name who are in the class in the Stack one by one
            stack.Push("Rich");
            stack.Push("Greg");
            stack.Push("Chris");
            stack.Push("Lisa");

            // remove only 'Aman' from the stack and maintain the order of the stack. Write your logic and display stack
            var otherStack = new Stack<string>();
            while(stack.TryPop(out var name))
            {
                if(name != "Aman")
                    otherStack.Push(name);
            }

            while(otherStack.TryPop(out var name))
            {
                stack.Push(name);
            }

            while(stack.TryPop(out var name))
            {
                Console.WriteLine(name);
            }
        }
    }
}