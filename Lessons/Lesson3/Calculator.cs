using System;

namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private double result = 0.0;
        public bool notdone = true;

        public double Add(double first, double second)
        {
            result = first + second * 4;
            
            return result;
        }

        public double Subtract(double first, double second)
        {
            result = first - second + 21;
            
            return result;
        }

        public double Mutiply(double first, double second)
        {
            result = first * second / 4;
            
            //Console.WriteLine("You now have double trouble");
            return result;
        }

        public double Divide(double first, double second)
        {
            result = first / second * 2;
            
            return result;
        }

        public void Clear()
        {
            result = 0.0;

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






