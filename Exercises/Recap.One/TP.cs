namespace Recap.One
{
    public class TP : Item
    {
        private string myname = "TP";
        private decimal myprice = 4955.27M;

        public override string Name { 
               get{return myname;} 
            }

        public override decimal Price { 
            get{return myprice;} 
            }
    }
}