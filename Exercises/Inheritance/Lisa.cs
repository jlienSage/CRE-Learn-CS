using System;

namespace Inheritance
{
    public class Lisa : Person
    {
        protected override decimal Tenure {get;} =2;
        protected override string Name {get;} ="Lisa";
        public string Car {get;} = "Volvo";


        public override string ToString()
        {
            
            //Console.WriteLine(base.ToString());       
            return (base.ToString() + $"My car is a {Car}");
           
        }

    }
}
