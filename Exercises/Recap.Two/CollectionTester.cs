using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recap.Two
{
    public static class CollectionTester
    {
        public static async Task<IEnumerable<(string type, long addTime, long lookupTime, long enumerateTime)>> TestCollections(long numberOfElements)
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

            var listAddTimeTask = Task.Run(() => AddStrings(myLinkedList, strings));
            var linkedListAddTimeTask = Task.Run(() => AddStrings(myDoubleList, strings));
            var hashSetAddTimeTask = Task.Run(() => AddStrings(myHashSet, strings));
            var sortedSetAddTimeTask = Task.Run(() => AddStrings(mySortedSet, strings));
            
            listAddTime = await listAddTimeTask;
            linkedListAddTime = await linkedListAddTimeTask;
            hashSetAddTime = await hashSetAddTimeTask;
            sortedSetAddTime = await sortedSetAddTimeTask;

            var listLookupTimeTask = Task.Run(() => LookupStrings(myLinkedList, strings));
            var linkedListLookupTimeTask = Task.Run(() => LookupStrings(myDoubleList, strings));
            var hashSetLookupTimeTask = Task.Run(() => LookupStrings(myHashSet, strings));
            var sortedSetLookupTimeTask = Task.Run(() => LookupStrings(mySortedSet, strings));

            listLookupTime = await listLookupTimeTask;
            linkedListLookupTime = await linkedListLookupTimeTask;
            hashSetLookupTime = await hashSetLookupTimeTask;
            sortedSetLookupTime = await sortedSetLookupTimeTask;

            var listEnumerateTimeTask = Task.Run(() => EnumerateCollection(myLinkedList));
            var linkedListEnumerateTimeTask = Task.Run(() => EnumerateCollection(myDoubleList));
            var hashSetEnumerateTimeTask = Task.Run(() => EnumerateCollection(myHashSet));
            var sortedSetEnumerationTimeTask = Task.Run(() => EnumerateCollection(mySortedSet));

            var listEnumerateTime = await listEnumerateTimeTask;
            var linkedListEnumerateTime = await linkedListEnumerateTimeTask;
            var hashSetEnumerateTime = await hashSetEnumerateTimeTask;
            var sortedSetEnumerationTime = await sortedSetEnumerationTimeTask;
            
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
            {                
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static IList<string> GetRandomStrings(long numberOfElements)
        {
            var strings = new List<string>();
            for (var i = 0; i < numberOfElements; i++)
                strings.Add(Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 12));
            return strings;
        }
    }
}