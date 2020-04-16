using System.Collections.Generic;


namespace Recap.One
{
    class Cart : ICart
    {
        //private item new Item();
        private List<Item> items = new List<Item>();

        public IEnumerable<Item> Items => items;

        public int TotalItems => items.Count;

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