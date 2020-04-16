using System;



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
            Cart cart = new Cart(); //create instance of cart

            var shopping = true;

            while (shopping)
            {
                Console.WriteLine("Add your item to the cart");
                var command = Console.ReadLine();
                switch (command)
                {
                    // TODO add items to cart based on command
                    case "TP":
                        var tp = new ToiletPaper();
                        cart.AddToCart(tp);
                        break;
                        case "HandSani":
                        HandSani handsani = new HandSani();
                        cart.AddToCart(handsani);
                        break;
                    case "done":
                        shopping = false;
                        ProcessCart(cart);
                        break;

                }

            }
        }

        public static void ProcessCart(ICart cart)
        {
            Console.WriteLine($"{cart.TotalItems} items in cart:");
            decimal TotalPrice = 0;
            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Name}: ${item.Price}");
                TotalPrice += item.Price; //+= is shorthand for TotalPrice = TotalPrice + item.Price
            }
            cart.ClearCart();
            Console.WriteLine($"Total price: {TotalPrice};");
        }
    }
}
