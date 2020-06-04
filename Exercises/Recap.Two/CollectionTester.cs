using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Recap.Two
{
    public static class CollectionTester
    {
        public static IEnumerable<(string type, long addTime, long lookupTime, long enumerateTime)> TestCollections(long numberOfElements)
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

            ICollection<string> myLinkedList = new List<string>();
            
            ICollection<string> myDoubleList = new LinkedList<string>();
            
            ICollection<string> myHashSet = new HashSet<string>();
            ICollection<string> mySortedSet = new SortedSet<string>();

            listAddTime = AddStrings(myLinkedList, strings);
            linkedListAddTime = AddStrings(myDoubleList, strings);
            hashSetAddTime = AddStrings(myHashSet, strings);
            sortedSetAddTime = AddStrings(mySortedSet, strings);

            listLookupTime = LookupStrings(myLinkedList, strings);
            linkedListLookupTime = LookupStrings(myDoubleList, strings);
            hashSetLookupTime = LookupStrings(myHashSet, strings);
            sortedSetLookupTime = LookupStrings(mySortedSet, strings);

            var listEnumerateTime = EnumerateCollection(myLinkedList);
            var linkedListEnumerateTime = EnumerateCollection(myDoubleList);
            var hashSetEnumerateTime = EnumerateCollection(myHashSet);
            var sortedSetEnumerationTime = EnumerateCollection(mySortedSet);
            
            var results = new List<(string type, long addTime, long lookupTime, long enumerateTime)>
            {
                (nameof(List<string>), listAddTime, listLookupTime, listEnumerateTime),
                (nameof(LinkedList<string>), linkedListAddTime, linkedListLookupTime, linkedListEnumerateTime),
                (nameof(HashSet<string>), hashSetAddTime, hashSetLookupTime, hashSetEnumerateTime),
                (nameof(SortedSet<string>), sortedSetAddTime, sortedSetLookupTime, sortedSetEnumerationTime)
            };
            return results;
        }

        private static long AddStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();

            foreach(var item in strings)
                collection.Add(item);

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static long LookupStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();

            foreach(var item in strings)
                collection.Contains(item);

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static long EnumerateCollection(ICollection<string> collection)
        {
            var stopwatch = Stopwatch.StartNew();

            foreach(var item in collection)
                // The line below is just to get the program to compile and run.
                item.Trim();

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