﻿using System;

namespace Recap.One
{
    /*
        Exercise:
            1. Create an implementation of ICart
            2. Create Item subclasses
            3. Add to cart in switch based on read command
            4. Calculate total price
        
        To run, change console value in launch.json to integratedTerminal:
            "console": "integratedTerminal",
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            ICart cart = null; // TODO create instance of cart

            var shopping = true;
            while(shopping)
            {
                var command = Console.ReadLine();
                switch(command)
                {
                    // TODO add items to cart based on command
                    case "Gloves" : 
                        cart.AddToCart(new Gloves());
                        break;

                    case "Mask" :
                        cart.AddToCart (new Mask());
                        break;
                        
                    case "done":
                        shopping = false;
                        break;
                }
            }
            
            ProcessCart(cart);
        }

        private static void ProcessCart(ICart cart)
        {
            Console.WriteLine($"{cart.TotalItems} items in cart:");
            decimal total = 0.00M;

            foreach(var item in cart.Items)
            {
                total += item.Price;

                Console.WriteLine($"{item.Name}: ${item.Price}");
            }
            cart.ClearCart();
            Console.WriteLine($"Total price: {total}."); 
        }
    }
}
