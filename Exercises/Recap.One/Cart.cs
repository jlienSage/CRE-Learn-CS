namespace Recap.One

{
    using System.Collections.Generic;
    //implement ICart class
    public class Cart: ICart
    {
 
        //Cart Constructor
        public Cart()
        {
            // 
            Items = new List<Item>();
        }

    
        IEnumerable<Item> Items { get; }
        // ??? unsure what to do here


        public int TotalItems 
        { 
            get;
            private set;
        }

        public void AddToCart(Item item)
        {

            //cart[TotalItems++] = item;
            //item.Name = name;
            //item.Price = price;
        }

                
        void ClearCart()
        {
            cart = null;
            totalItems = 0;
        }
    }

}
