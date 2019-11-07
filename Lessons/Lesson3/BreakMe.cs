using System;


namespace Lesson3
{
    public class BreakMe : Calculator
    {
        public override void Multiply(decimal first)
        {
           CurrentValue = first + 25;
           //return Subtract(first);
        }
        public override void Add(decimal first)
        {
           CurrentValue = first - 25;
           //return Subtract(first);
        }
        public override void Subtract(decimal first)
        {
           CurrentValue = first + 25;
           //return Subtract(first);
        }

    }
}
