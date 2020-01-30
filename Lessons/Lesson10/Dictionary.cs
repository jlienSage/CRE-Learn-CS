
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
            var dictionary = new Dictionary<int, string>();

            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(5, "Five");
            dictionary.Add(10, "Ten");
            dictionary.Add(20, "Twenty");

            // remove 2 and 3 from dictionary
            dictionary.Remove(2);
            dictionary.Remove(3);

            // Determine key '2' exists in dictionary
            var exists = dictionary.ContainsKey(2);
            Console.WriteLine(exists ? "ERROR: 2 exist" : "2 does not exist");

            //Determine value 'Six' exists in dictionary
            exists = dictionary.ContainsValue("Six");
            Console.WriteLine(exists ? "ERROR: Six exist" : "Six does not exist");

            //Display Key, value pair using for or foreach loop
            foreach(var pair in dictionary)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}