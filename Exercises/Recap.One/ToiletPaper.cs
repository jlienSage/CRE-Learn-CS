namespace Recap.One
{
    public class ToiletPaper : Item
    {

        private string name;
        private decimal price;

        public ToiletPaper()
        {
            name = "Toilet Paper";
            price = 1000;
        }

        public override string Name
        {
            get
            {
                return name;
            }
        }

        /* or
        public override string name
        {
            get;
        }
        */

        public override decimal Price
        {
            get
            {
                return price;
            }
        }
    }
}