
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



            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty

            Dictionary<int, string> dict = new Dictionary<int, string>();
            
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(5, "Five");
            dict.Add(10, "Ten");
            dict.Add(20, "Twenty");



            // remove 2 and 3 key/value pair entry from Dictionary

            dict.Remove(2);
            dict.Remove(3);

            // Determine key '2' exists in Dictionary

            if (dict.ContainsKey(2)==true) 
          { 
              Console.WriteLine("Key 2 is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Key 2 is not found...!!"); 
          } 

            //Determine value 'Six' exists in Dictionary

            if (dict.ContainsValue("Six")==true) 
          { 
              Console.WriteLine("Value Six is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Value Six is not found...!!"); 
          } 


            //Display Key, value pair using for or foreach loop
             foreach(KeyValuePair<int, string> ele1 in dict) 
          { 
              Console.WriteLine("{0} and {1}", 
                        ele1.Key, ele1.Value); 
          } 
          Console.WriteLine(); 

        }
    }
}