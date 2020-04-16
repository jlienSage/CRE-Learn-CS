using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Recap.Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0 && long.TryParse(args[0], out long numberOfElements))
                CollectionTester.TestCollections(numberOfElements);
            else
                CollectionTester.TestCollections(1000);
        }
    }
}
