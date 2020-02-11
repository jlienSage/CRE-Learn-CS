
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
            // Homework: Create a Stack and fill in the lines as commented. See below for more details.

            // C# program to illustrate how to 
            // Create a stack 
            // Using Stack class created Co worker stack then holding stack.

            Stack CoWorker_stack = new Stack();
            Stack CoHold_stack = new Stack();

            // Adding elements in the Stack 
            // Using Push method 

            // Add 'Aman' and 'John' in the Stack

            Console.WriteLine("Adding Aman and John to the Stack");

            CoWorker_stack.Push("Aman");
            CoWorker_stack.Push("John");

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", CoWorker_stack.Count);

            Console.Write("Displaying Values in Stack after adding John and Aman:");
            PrintValuesCoWorker(CoWorker_stack);

            // Add all the students name who are in the class in the Stack one by one

            CoWorker_stack.Push("Lisa");
            CoWorker_stack.Push("Greg");
            CoWorker_stack.Push("Rich");

            Console.WriteLine("Total elements present in" +
                       " my_stack: {0}", CoWorker_stack.Count);

            Console.Write("Display of current coworkers after added:");
            PrintValuesCoWorker(CoWorker_stack);

            // While there are values in the coworker stack loop until you reach Aman or end of stack.

            var count = CoWorker_stack.Count;
            while (count > 0)
            {
                count = count - 1;
                // Look at first name in stack.
                var Name = CoWorker_stack.Peek();
                // Locate Aman
                if (Name == "Aman")
                {
                    // Pop off Aman
                    CoWorker_stack.Pop();
                    // Count saved people from stack above Aman's name. 
                    var savedEntries = CoHold_stack.Count;
                    // If count is above 0 then execute while loop.
                    while (savedEntries > 0)
                    {
                        CoWorker_stack.Push(CoHold_stack.Pop());  // Repopulate the list'
                        savedEntries = savedEntries - 1;   // Decrement saved entries -1
                    }
                    count = 0;  // signal we are done with the loop
                    Console.Write("\tValues:");
                    PrintValuesCoWorker(CoWorker_stack);
                }
                else
                {
                    // Remove Aman from the list but keep everything in order.
                    // Save this person
                    var namePop = CoWorker_stack.Pop();
                    // Saves for later
                    CoHold_stack.Push(namePop);  
                    Console.WriteLine("Popping '{0}'", namePop);
                    Console.Write("\tValues after the pops:");
                    PrintValuesCoWorker(CoWorker_stack);

                }
            } // end of while loop
        }

        public static void PrintValuesCoWorker(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();

        }

    }

}















