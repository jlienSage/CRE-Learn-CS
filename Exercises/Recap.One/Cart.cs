namespace Recap.One
{
    using System;
    using System.Collections.Generic;

    //implement ICart class
    public class Cart: ICart
    {
        private List<Item> items;

        //Cart Constructor
        public Cart()
        {
            // Cart is a list of items
            items = new List<Item>();
        }

    
        public IEnumerable<Item> Items => items; 
            


        public int TotalItems  => items.Count;

        public void AddToCart(Item item)
        {
            items.Add(item);
        }

        public void ClearCart()
        {
            items.Clear();
        }
    }

}
