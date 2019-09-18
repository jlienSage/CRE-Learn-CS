using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var brokenCalc = new BrokenCalculator(2);
            brokenCalc.Add(3);
            var currVal = brokenCalc.CurrentValue;
            brokenCalc.Subtract(2);
            currVal = brokenCalc.CurrentValue;
            brokenCalc.Divide(3);
        }
    }
}
