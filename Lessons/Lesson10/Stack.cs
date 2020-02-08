
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

            // C# program to illustrate how to 
            // Create a stack 
            // Using Stack class

            Stack CoWorker_stack = new Stack();


            // Adding elements in the Stack 
            // Using Push method 
            // Add all the students name who are in the class in the Stack one by one

            CoWorker_stack.Push("Lisa");
            CoWorker_stack.Push("Greg");
            CoWorker_stack.Push("Rich");

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", CoWorker_stack.Count);

            Console.Write("Display of current coworkers after added:");
            PrintValuesCoWorker(CoWorker_stack);

            // Add 'Aman' and 'John' in the Stack

            Console.WriteLine("Adding Aman and John to the Stack");



            CoWorker_stack.Push("Aman");
            CoWorker_stack.Push("John");

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", CoWorker_stack.Count);

            Console.Write("Displaying Values in Stack after adding John and Aman:");
            PrintValuesCoWorker(CoWorker_stack);

            // remove only 'Aman' from the stack and maintain the order of the stack. Write your logic and display stack

            var Name = CoWorker_stack.Pop();
            {
                if (Name == "Aman")
                {

                    Console.Write("\tValues:");
                    PrintValuesCoWorker(CoWorker_stack);
                }
                else
                {
                    //Remove Aman from the list but keep everything in order.
                    Console.WriteLine("Popping '{0}'", CoWorker_stack.Pop());
                    Console.Write("\tValues:");
                    PrintValuesCoWorker(CoWorker_stack);
                    Console.Write("Adding John back into stack");
                    CoWorker_stack.Push("John");
                    PrintValuesCoWorker(CoWorker_stack);

                }
            }
        }

        public static void PrintValuesCoWorker(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();

        }

    }

}















