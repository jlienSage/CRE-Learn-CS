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

            // ***********
            // TODO for each type of collection
            // 1. Create an instance of the type of collection
            // 2. Call AddStrings on the instance of the type and assign the result to a variable
            // 3. Call LookupStrings on the instance of the type and assign the result to a variable
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

            // ***********
            // TODO implement adding each of the passed strings to the collection, one at a time.
            // ***********

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static long LookupStrings(ICollection<string> collection, IList<string> strings)
        {
            var stopwatch = Stopwatch.StartNew();

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