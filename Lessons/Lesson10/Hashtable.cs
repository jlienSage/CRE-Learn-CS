
using System;
using System.Collections;

namespace DataStructure
{
    public partial class Lesson10
    {
        public static void Hashtable()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Hashtable Example: ");
            Console.WriteLine("----------------------------- ");
            //Homework: Create a Hashtable and fill in the lines. See below for more details.

            // Create a Hashtable
            Hashtable ht = new Hashtable();

            // Add Key/Value Pair          
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(5, "Five");
            ht.Add(10, "Ten");
            ht.Add(20, "Twenty");

            //Remove 2 and 3 from Hash table
            ht.Remove(2);
            ht.Remove(3);

            //Display Key, value pair using for or foreach loop                                 
            foreach (DictionaryEntry ele1 in ht)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }

            // Determine key '2' exists in Hashtable
            Console.WriteLine();
            if (ht.ContainsKey(2) == true)
            {
                Console.WriteLine("Key 2 is found...!!");
            }

            else
            {
                Console.WriteLine("Key 2 is not found...!!");
            }

            // Determine value 'Six' exists in Hashtable
            if (ht.ContainsValue("Six") == true)
            {
                Console.WriteLine("Value Six is found...!!");
            }

            else
            {
                Console.WriteLine("Value Six is not found...!!");
            }

        }
    }
}