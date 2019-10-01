using System;

namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private decimal result = 0.0M;
        public bool notdone = true;

        public decimal Add(decimal first, decimal second)
        {
            result = first + second * 4;
            
            return result;
        }

        public decimal Subtract(decimal first, decimal second)
        {
            result = first - second + 21;
            
            return result;
        }

        public decimal Mutiply(decimal first, decimal second)
        {
            result = first * second / 4;
            
            //Console.WriteLine("You now have double trouble");
            return result;
        }

        public decimal Divide(decimal first, decimal second)
        {
            result = first / second * 2;
            
            return result;
        }

        public void Clear()
        {
            result = 0.0M;

            Console.WriteLine("Result has been cleared");
            return;
        }
        public void Exit()
        {
            notdone = false;

            Console.WriteLine("Program has exited");
            return;
        }

    }
}






