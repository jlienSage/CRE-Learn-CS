
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



            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty
            Hashtable my_hashtable1 = new Hashtable();

            my_hashtable1.Add(1, "One");
            my_hashtable1.Add(2, "Two");
            my_hashtable1.Add(3, "Three");
            my_hashtable1.Add(5, "Five");
            my_hashtable1.Add(10, "Ten");
            my_hashtable1.Add(20, "Twenty");





            // remove 2 and 3 from Hash table

            my_hashtable1.Remove(2);
            my_hashtable1.Remove(3);



            // Determine key '2' exists in Hashtable
               if (my_hashtable1.ContainsKey(2)==true) 
          { 
              Console.WriteLine("Key 2 is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Key 2 is not found...!!"); 
          } 

            //Determine value 'Six' exists in hashtable
                if (my_hashtable1.ContainsValue("Six")==true) 
          { 
              Console.WriteLine("Value Six is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Value Six is not found...!!"); 
          } 


            //Display Key, value pair using for or foreach loop

                         foreach(DictionaryEntry ele1 in my_hashtable1) 
          { 
              Console.WriteLine("{0} and {1}", 
                        ele1.Key, ele1.Value); 
          } 
          Console.WriteLine(); 


        }
    }
}