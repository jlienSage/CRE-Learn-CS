
using System;
using System.Collections;       //rich added this

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
            Hashtable myHashTable = new Hashtable();


            // Add Key/Value Pair
            // Key/Value Pair 
            // 1 => One
            // 2 => Two
            // 3 => Three
            // 5 => Five
            // 10 => Ten
            // 20 => Twenty
            myHashTable.Add (1, "One");
            myHashTable.Add (2, "Two");
            myHashTable.Add (3, "Three");
            myHashTable.Add (5, "Five");
            myHashTable.Add (10, "Ten");
            myHashTable.Add (20, "Twenty");

            // remove 2 and 3 from Hash table
            myHashTable.Remove (2);
            myHashTable.Remove (3);


            // Determine key '2' exists in Hashtable
            if (myHashTable.ContainsKey (2))
                Console.WriteLine ("2 is a key");
            else
            {
                Console.WriteLine ("2 is not a key");
            }
            
            //Determine value 'Six' exists in hashtable
            if (myHashTable.ContainsValue ("Six"))
                Console.WriteLine ("2 is a key");
            else
            {

                Console.WriteLine ("\"Six\" is not a key");}




            //Display Key, value pair using for or foreach loop
            foreach (DictionaryEntry pair in myHashTable)
                Console.WriteLine ($"Key and Value: {pair.Key}, {pair.Value}");


        }
    }
}