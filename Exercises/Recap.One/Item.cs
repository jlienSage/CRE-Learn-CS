namespace Recap.One
{
    public abstract class Item
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }
    }


        public class Pencil : Item
    {
        private string iname = "Pencil";
        private decimal iprice = .50M;

        public override string Name 
        { 
            get (return iname); 
        }

        public override decimal Price 
        { 
            get(return iprice);
        } 
    }
}