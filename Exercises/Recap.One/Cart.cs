using System.Collections.Generic;
using System.Linq;

namespace Recap.One
{
    public class Cart : ICart;
    {
        //Cart Constructor
        public Cart()
        {
            Items = new List<Item>();
        } 

        public IEnumerable<Item> Items { get; }


        public void AddToCart(Item item);
        {
            Items.Append(item);
        }

        public void ClearCart()


    }
}