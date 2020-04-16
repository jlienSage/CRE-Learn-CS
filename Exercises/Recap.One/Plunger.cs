namespace Recap.One
{

    public class Plunger : Item
    {

        private string name;
        private decimal price;

        public Plunger()
        {
            name = "Plunger";
            price = 20;
        }

        public override string Name
        {
            get
            {
                return name;
            }
        }

        public override decimal Price
        {
            get
            {
                return price;
            }
        }

    }
}