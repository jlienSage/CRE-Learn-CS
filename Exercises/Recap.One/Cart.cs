using System.Collections.Generic;


namespace Recap.One
{
    class Cart : ICart
    {
        public IEnumerable<Item> Items { get; }
        public int TotalItems { get; }

        public void AddToCart(Item item){

        }
        public void ClearCart(){

        }
    }
}