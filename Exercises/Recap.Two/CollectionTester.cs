using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Recap.Two
{
    public static class CollectionTester
    {
        public static ICollection<(string type, long elapsedMilliseconds)> TestCollections(long numberOfElements)
        {
            IList<string> strings = GetRandomStrings(numberOfElements);
            long listMilliseconds = 0;
            long linkedListMilliseconds = 0;
            long hashSetMilliseconds = 0;
            long sortedSetMilliseconds = 0;
            var stopwatch = Stopwatch.StartNew();

            // ***********
            // TODO for each type of collection
            // 1. Call AddThousandElements on an instance of the type
            // 2. Stop the stopwatch
            // 3. Assign stopwatch.ElapsedMilliseconds to the appropriate 
            // 4. Restart the stopwatch
            // ***********

            var results = new List<(string type, long elapsedMilliseconds)>
            {
                (nameof(List<string>), listMilliseconds),
                (nameof(LinkedList<string>), linkedListMilliseconds),
                (nameof(HashSet<string>), hashSetMilliseconds),
                (nameof(SortedSet<string>), sortedSetMilliseconds)
            };
            return results;
        }

        private static void AddStrings(ICollection<string> s, IList<string> strings)
        {
            // TODO
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