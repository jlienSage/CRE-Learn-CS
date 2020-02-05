
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

            Dictionary<int, string> My_dict = new Dictionary<int, string>();

            // Add Key/Value Pair
            My_dict.Add(1, "One");
            My_dict.Add(2, "Two");
            My_dict.Add(3, "Three");
            My_dict.Add(5, "Five");
            My_dict.Add(10, "Ten");
            My_dict.Add(20, "Twenty");

            // Using Remove() method to remove
            // remove 2 and 3 key/value pair entry from Dictionary
            My_dict.Remove(2);
            My_dict.Remove(3);

            //Display Key, value pair using for or foreach loop
            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();

            // Determine key '2' exists in Dictionary
             if (My_dict.ContainsKey(2)==true) 
            { 
              Console.WriteLine("Key 2 is found...!!"); 
            } 
  
            else
            { 
               Console.WriteLine("Key 2 is not found...!!"); 
            } 

            // Determine value 'Six' exists in Dictionary
             if (My_dict.ContainsValue("Six")==true) 
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