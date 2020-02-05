
using System;
using System.Collections.Generic;
namespace DataStructure
{
    public partial class Lesson10
    {
        public static void Dictionary()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Dictionary Example: ");
            Console.WriteLine("----------------------------- ");
            //Homework: Create a Dictionary and fill in the lines. See below for more details.
            // Create a Dictionary
            Dictionary<int, string> numDictionary = new Dictionary<int, string>();


            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty
            numDictionary.Add (1, "One");
            numDictionary.Add (2, "Two");
            numDictionary.Add (3, "Three");
            numDictionary.Add (5, "Five");
            numDictionary.Add (10, "Ten");
            numDictionary.Add (20, "Twenty");

            // remove 2 and 3 key/value pair entry from Dictionary
            numDictionary.Remove (2);
            numDictionary.Remove (3);


            // Determine key '2' exists in Dictionary
            if (numDictionary.ContainsKey (2))
                Console.WriteLine ("'2' exists");
            else
                Console.WriteLine ("'2' doesn't exist in dictionary");



            //Determine value 'Six' exists in Dictionary
            if (numDictionary.ContainsValue ("Six"))
                Console.WriteLine ("\"Six\" exists");
            else
                Console.WriteLine ("\"Six\" doesn't exist in dictionary");

            //Display Key, value pair using for or foreach loop
            Console.WriteLine("looping through each ValuePair");
            foreach (KeyValuePair <int, string> itemR in numDictionary)
            {
                Console.WriteLine($"key and value: {itemR.Key} {itemR.Value}");
                //Console.WriteLine(item.Value);
            }
        }
    }
}