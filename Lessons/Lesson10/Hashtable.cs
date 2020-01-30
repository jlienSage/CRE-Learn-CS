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
            var hashtable = new Hashtable();

            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            hashtable.Add(5, "Five");
            hashtable.Add(10, "Ten");
            hashtable.Add(20, "Twenty");

            // remove 2 and 3 from Hash table
            hashtable.Remove(2);
            hashtable.Remove(3);


            // Determine key '2' exists in Hashtable
            var exists = hashtable.ContainsKey(2);
            Console.WriteLine(exists ? "ERROR: 2 exist" : "2 does not exist");

            //Determine value 'Six' exists in hashtable
            exists = hashtable.ContainsValue("Six");
            Console.WriteLine(exists ? "ERROR: Six exist" : "Six does not exist");

            //Display Key, value pair using for or foreach loop
            foreach(DictionaryEntry pair in hashtable)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}