namespace Inheritance
{
    public class John : Person
    {
        private int age = 26;
        protected override string Name => "John";
        protected override decimal Tenure => 3.5M;

        public override string ToString()
        {
            return base.ToString() + $" I am {age} years old.";
        }
    }
}