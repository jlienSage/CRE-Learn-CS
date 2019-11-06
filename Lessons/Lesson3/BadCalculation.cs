
using System;

namespace Lesson3
{
    public class BadCalculation : Calculator
    {
        public override void Add(int num1)
        {
            base.Add(num1 + 1);
        }
    }
}


