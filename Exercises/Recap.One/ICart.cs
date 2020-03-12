namespace Recap.One
{
    using System.Collections.Generic;

    public interface ICart
    {
        IEnumerable<Item> Items { get; }

        int TotalItems { get; }

        void AddToCart(Item item);
        
        void ClearCart();
    }
}