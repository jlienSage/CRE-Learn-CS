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
            try{
                brokenCalc.Divide(0);
            }
            catch (Exception e){
                Console.WriteLine($"I'm bad at math: {e}");
            }
        }
    }
}
