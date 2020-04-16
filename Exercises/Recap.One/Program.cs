using System;

namespace Recap.One
{
    /*
        Exercise:
            1. Create an implementation of ICart (creates new file)
            2. Create Item subclasses (should a new file)
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
                    case "tp":
                        cart.AddToCart(new ToiletPaper());
                        break;

                    case "rice":
                        cart.AddToCart(new Rice());
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
            Console.WriteLine($"Total price: {total}. ");
        }
    }
}
