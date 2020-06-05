using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Recap.Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long numberOfElements;
            if (args.Length == 0 || !long.TryParse(args[0], out numberOfElements))
                numberOfElements = 1000000;

            var result = CollectionTester.TestCollections(numberOfElements).GetAwaiter().GetResult();
            PrintResult(result);
        }

        public static void PrintResult(IEnumerable<(string type, long addTime, long lookupTime, long enumerateTime)> results)
        {
            foreach(var result in results)
            {
                Console.WriteLine($"{result.type}:");
                Console.WriteLine($"    Add:    {result.addTime}m");
                Console.WriteLine($"    Lookup: {result.lookupTime}m");
                Console.WriteLine($"    Enumerate: {result.enumerateTime}m");
            }
        }
    }
}
