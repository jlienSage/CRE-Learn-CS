
using System;

namespace Lesson3
{
    public class BadCalculation : Calculator
    {
        public override void Add(int num1)
        {
            currentValue = currentValue + num1 +1;
        }
    }
}


