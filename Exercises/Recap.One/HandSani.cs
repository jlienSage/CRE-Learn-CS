namespace Recap.One
{
    public class HandSani : Item
    {
        private string myname = "Hand Sanitizer";
        private decimal myprice = 55.77M;

        public override string Name { 
               get{return myname;} 
            }

        public override decimal Price { 
            get{return myprice;} 
            }
     }           
}