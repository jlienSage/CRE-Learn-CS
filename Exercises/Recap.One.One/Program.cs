using System;
using System.Collections.Generic;
using System.Linq;

namespace Recap.One.One
{
    /*
        Exercise:
            1. Create Item classes (classes that inherent from Item).
            2. Add these items to the cart.
            3. Iterate over the items to calculate the total price.
        
        No command line interaction is required for this exercise (i.e. Console.ReadLine() is not necessary).
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            var cart = new List<Item>();
            // Add items
            cart.Add(new ToiletPaper());
            cart.Add(new ToiletPaper());
            cart.Add(new ToiletPaper());
            cart.Add(new ToiletPaper());
            // Iterate over items to calculate total.
            Console.WriteLine("Items in cart:");
            cart.ForEach(i => Console.WriteLine($"  {i.ToString()}"));
            decimal total = cart.Sum(i => i.Price);
            Console.WriteLine($"Your total is: {total:0.00}.");
        }
    }
}
