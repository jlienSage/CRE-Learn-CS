namespace Recap.One
{
    using System;    
    using System.Collections.Generic;
    


    public class Cart : ICart

    {
       private List<Item> items;
        
        public Cart()
        {
            items = new List<Item>(); 
            TotalItems = 0;           

        }

       public IEnumerable<Item> Items => items;     

        public int TotalItems 
        {
            get;
            private set;
        }

       public void AddtoCart(Item item)

       {
           items.Add(item);  
           TotalItems++

       }

       public void ClearCart()

       {
           items.Clear();
       }



       

            //cart[TotalItems++] = Item;

    }
}