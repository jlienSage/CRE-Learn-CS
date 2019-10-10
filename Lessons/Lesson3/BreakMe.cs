using System;


namespace Lesson3
{
    public class BreakMe : Calculator
    {
        public override decimal Multiply(decimal first)
        {
            return Subtract(first);
        }

    }
}
