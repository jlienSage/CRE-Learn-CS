using System;

namespace Inheritance
{
    public  class Rich : Person
    {
        protected override decimal Tenure {get;} = 19;
        protected override string Name => "Rich";
        //public string Location = "Beaverton";
        public string Location {get;} = "Beaverton";

        public  override string ToString()
        {
            //test comment2
            //return $"My name is {Name}. I have been at Sage {Tenure} years.";
            //return (base.ToString() + "(I like C#)");
            return (base.ToString() + $"I work in {Location}");
            //Console.WriteLine ("Hello" + base.ToString() + $"I work in {Location}");
        }
    }
}