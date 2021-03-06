﻿using System;
using System.Collections.Generic;

namespace Recap.One.One
{
    /*
        Exercise:
            1. Create Item classes (classes that inherent from Item).
            2. Add these items to the cart.
            3. Iterate over the items to calculate the total price.
        
        No command line interaction is required for this exercise (i.e. Console.ReadLine() is not necessary).

        To run, change console value in launch.json to integratedTerminal:
            "console": "integratedTerminal",
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            var cart = new List<Item>();
            // Add items
            var total = 0.0M;
            // Iterate over items to calculate total.
            Console.WriteLine("Items in cart:");
            cart.ForEach(i => Console.WriteLine($"  {i.Name}: {i.Price}"));
            Console.WriteLine($"Your total is: {total}.");
        }
    }
}
