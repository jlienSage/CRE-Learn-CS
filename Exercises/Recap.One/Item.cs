namespace Recap.One
{
    public abstract class Item
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }

        public override string ToString()
        {
            return $"{Name}: ${Price}";
        }
    }
}