using System;
using System.Collections;

namespace DataStructure
{
    public partial class Lesson10
    {
        public static void ArrayList()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("ArrayList Example: ");
            Console.WriteLine("----------------------------- ");

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add(25);
            
            myAL.Add(36.3);
            myAL.Add(36.4);
            myAL.RemoveAt(3);
            
            myAL.Add("RICH string added");
            

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}