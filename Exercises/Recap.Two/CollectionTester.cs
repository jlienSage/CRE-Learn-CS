using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Recap.Two
{
    public static class CollectionTester
    {
        public static IEnumerable<(string type, long addTime, long lookupTime)> TestCollections(long numberOfElements)
        {
            //strings: list of strings - consisting of "*" character
            IList<string> strings = GetRandomStrings(numberOfElements);
            long listAddTime = 0;
            long listLookupTime = 0;
            
            long linkedListAddTime = 0;
            long linkedListLookupTime = 0;
            
            long hashSetAddTime = 0;
            long hashSetLookupTime = 0;
            
            long sortedSetAddTime = 0;
            long sortedSetLookupTime = 0;
            

            ICollection<string> myLinkedList = new List<string>();
            
            ICollection<string> myDoubleList = new LinkedList<string>();
            
            ICollection<string> myHashSet = new HashSet<string>();
            ICollection<string> mySortedSet = new SortedSet<string>();

            // ***********
            // TODO for each type of collection
            // 1. Create an instance of the type of collection
            // 2. Pass the instance of the type and the strings variable as agruments to 
            //      AddStrings and assign the  return result to the appropriate variable
            // 3. Pass the instance of the type and the strings variable as agruments to 
            //      LookupStrings and assign the return value to the appropriate variable
            //          old: Call LookupStrings on the instance of the type and assign the result to a variable
            // Collections to test are:
            //    - linked list (List<T>)
            //    - doubley-linked list (LinkedList<T>)
            //    - hash set (HashSet<T>)
            //    - sorted set (SortedSet<T>)
            // ***********
            // Purpose: List name of each collection and elapsed time 
            //  (used for printing in main())
            // AddStrings(myLinkedList(), strings);
            // LookupStrings(myLinkedList(), strings);
            //private static long AddStrings(ICollection<string> collection, IList<string> strings)
            listAddTime = AddStrings(myLinkedList, strings);
            linkedListAddTime = AddStrings(myDoubleList, strings);
            hashSetAddTime = AddStrings(myHashSet, strings);
            sortedSetAddTime = AddStrings(mySortedSet, strings);

            listLookupTime = LookupStrings(myLinkedList, strings);
            linkedListLookupTime = LookupStrings(myDoubleList, strings);
            hashSetLookupTime = LookupStrings(myHashSet, strings);
            sortedSetLookupTime = LookupStrings(mySortedSet, strings);

            var results = new List<(string type, long addTime, long lookupTime)>
            {
                (nameof(List<string>), listAddTime, listLookupTime),
                (nameof(LinkedList<string>), linkedListAddTime, linkedListLookupTime),
                (nameof(HashSet<string>), hashSetAddTime, hashSetLookupTime),
                (nameof(SortedSet<string>), sortedSetAddTime, sortedSetLookupTime) 
            };
            return results;
        }

        private static long AddStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();
            //debug code
            int i = 0;
            // ***********
            // TODO implement adding each of the passed strings to the collection, 
            //      one at a time.
            // ***********
            // 

           foreach (var stringX in strings)
            {
                collection.Add(stringX);
                //Console.WriteLine(collection.type);
                i++;
                //Debug
                /*
                Console.WriteLine("AddString " + i.ToString() + stringX);
                */
            }
            stopwatch.Stop();
            //debug
            //Console.WriteLine("AddString Elapsed time: " + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static long LookupStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();
            //debug code
            int i = 0;

            // ***********
            // TODO implement looking up (i.e. does the collection 'Contain' the string) the elements.
            // ***********
            foreach (var stringX in strings)
            {
                foreach (var stringY in collection)
                {
 
                    i++;
                    //Debug
   //                 Console.WriteLine("LookupString " + i.ToString() + stringX);
                    //Console.WriteLine(s, stringX);
                    if (stringX == stringY)
                        break;
                }
            }
            stopwatch.Stop();
            //debug code
 //           Console.WriteLine("Lookup Elapsed time: " + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static IList<string> GetRandomStrings(long numberOfElements)
        {
            var strings = new List<string>();
            var rand = new Random();
            for (var i = 0; i < numberOfElements; i++)
                strings.Add(new string('*', rand.Next(0, 100)));
            return strings;
        }
    }
}