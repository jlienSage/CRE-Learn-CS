
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

            Dictionary<int, string> dict =
                       new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(5, "Five");
            dict.Add(10, "Ten");
            dict.Add(20, "Twenty");


            // remove 2 and 3 key/value pair entry from Dictionary

            dict.Remove(2);
            dict.Remove(30);

            // Determine key '2' exists in Dictionary

            var KeyV = 2;
            var Valu = "Six";

            if (dict.ContainsKey(KeyV) == true)
            {
                Console.WriteLine($"Key {KeyV} is found");
            }

            else
            {
                Console.WriteLine($"Key {KeyV} is not found");
            }

            //Determine value 'Six' exists in Dictionary

            if (dict.ContainsValue(Valu) == true)
            {
                Console.WriteLine($"Value {Valu} is found");
            }

            else
            {
                Console.WriteLine($"Value {Valu} is not found");
            }

            //Display Key, value pair using for or foreach loop


            foreach (KeyValuePair<int, string> val in dict)
            {
                Console.WriteLine("{0} and {1}",
                            val.Key, val.Value);
            }
            Console.WriteLine();
        }
    }
}