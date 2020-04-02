namespace Recap.One.One
{

    public class PaperTowels : Item
    {

        private string name;
        private decimal price;

        public PaperTowels()
        {
            name = "PaperTowels";
            price = 5;
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