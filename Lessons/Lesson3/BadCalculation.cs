
using System;

namespace Lesson3
{
    public class BadCalculation : Calculator, ICalculator 
    {
        public override void Add(decimal x)
        {
            base.Add(x + 1);
        }

        //public void Subtract(decimal x);

        //public void Multiple(decimal x);

        //public void Divide(decimal x);



    }
}


