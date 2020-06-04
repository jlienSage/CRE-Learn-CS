using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Recap.Two
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            //RD: what is "out long numberOfElements"? how does this get loaded?
            if (args.Length > 0 && long.TryParse(args[0], out long numberOfElements))
                PrintResult(CollectionTester.TestCollections(numberOfElements));
            else
                //PrintResult(CollectionTester.TestCollections(1000000));
                PrintResult(CollectionTester.TestCollections(1000000));
        }

        public static void PrintResult(IEnumerable<(string type, long addTime, long lookupTime)> results)
        {
            foreach(var result in results)
            {
                Console.WriteLine($"{result.type}:");
                Console.WriteLine($"    Add:    {result.addTime}m");
                Console.WriteLine($"    Lookup: {result.lookupTime}m");
            }
        }
    }
}
