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
           IList<string> strings = GetRandomStrings(numberOfElements);
            long listAddTime = 0;
            long listLookupTime = 0;
            long linkedListAddTime = 0;
            long linkedListLookupTime = 0;
            long hashSetAddTime = 0;
            long hashSetLookupTime = 0;
            long sortedSetAddTime = 0;
            long sortedSetLookupTime = 0;


ICollection<string> myList = new List<string>();

listAddTime = AddStrings(myList, strings);
listLookupTime = LookupStrings(myList, strings);

ICollection<string> myDoubleList = new LinkedList<string>();

linkedListAddTime = AddStrings(myDoubleList, strings);
linkedListLookupTime = LookupStrings(myDoubleList, strings);

ICollection<string> myHashSet = new HashSet<string>();

hashSetAddTime = AddStrings(myHashSet, strings);
hashSetLookupTime = LookupStrings(myHashSet, strings);

ICollection<string> mySortedSet = new SortedSet<string>();

sortedSetAddTime = AddStrings(mySortedSet, strings);
sortedSetLookupTime = LookupStrings(mySortedSet, strings);

            

            // ***********
            // TODO for each type of collection
            // 1. Create an instance of the type of collection
            // 2. Pass the instance of the type and the strings variable as arguments to AddStrings and assign the return value to the appropriate variable.
            // 3. Pass the instance of the type and the strings variable as arguments to LookupStrings and assign the return value to the appropriate variable.
            // Collections to test are:
            //    - linked list (List<T>)
            //    - doubley-linked list (LinkedList<T>)
            //    - hash set (HashSet<T>)
            //    - sorted set (SortedSet<T>)
            // ***********
            
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
            
           foreach (var item in strings)
           {
               collection.Add(item);
               //Console.WriteLine(item);
               
           }
            
            // ***********
            // TODO implement adding each of the passed strings to the collection, one at a time.
            // ***********

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static long LookupStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();

            foreach (var item in collection)
           {
               strings.Contains(item);
                             
           }

            // ***********
            // TODO implement looking up (i.e. does the collection 'Contain' the string) the elements.
            // ***********

            stopwatch.Stop();
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