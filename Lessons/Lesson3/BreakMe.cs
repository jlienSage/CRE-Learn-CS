using System;


namespace Lesson3
{
    public class BreakMe : Calculator
    {
        public override decimal Mutiply(decimal first)
        {
           return Subtract(first);
        }

    }
}
