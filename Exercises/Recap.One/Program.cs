using System;


namespace Recap.One
{
    using rich_item;
    /*
        Exercise:
            1. Create an implementation of ICart
            2. Create Item subclasses
            3. Add to cart in switch based on read command
            4. Calculate total price
        
        To run, change console value in launch.json to integratedTerminal:
            "console": "integratedTerminal",

        QUESTIONS:
            -what is in the readline? item and price? item only?
                what should we do when we see an item on the readline?
                do we load up several Item subclasses?
            -AddToCart() has an Item parameter. how does the readline input get turned into an item and price?
            -How do we use IEnumberable?
            -If the Item class only has gets, how do we load an item?

    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //ICart cart = null; // TODO create instance of cart
            Cart cart = new Cart();       //richcode

            var shopping = true;
            while(shopping)
            {
                var command = Console.ReadLine();
                
                switch(command)
                {
                    // TODO add items to cart based on command
                    case "done":
                        shopping = false;
                        break;
                    //richcode
                    case "rich":
                        Console.WriteLine ("Hello Rich");
                        break;
                    case "pencil":
                        Pencil item = new Pencil();
                        cart.AddToCart(item);
                        break;
                    /* case "pen": 
                        Pen item = new Pen();
                        cart.AddToCart(item);
                        break;
                    */
                    case "notebook":
                        Console.WriteLine("Sorry, out of stock");
                        break;
                    default:
                        Console.WriteLine("Error. Re-enter name");
                        break;
                }
            }
            
            ProcessCart(cart);
        }

        private static void ProcessCart(ICart cart)
        {
            decimal totalPrice = 0;     //richcode
            Console.WriteLine($"{cart.TotalItems} items in cart:");
            foreach(var item in cart.Items)
            {
                Console.WriteLine($"{item.Name}: ${item.Price}");
                totalPrice =+ item.Price;       //richcode
            }
            cart.ClearCart();
            //Console.WriteLine("Total price: "); // TODO
            Console.WriteLine("Total Price:  ${totalPrice}");  //richcode
        }
    }
}
