using System;

namespace Lesson3
{
    public class BrokenCalculator
    {
        private double currentValue = 0;
        public double NewTotal
        {
            get
            {
                return currentValue;
            }
        }

        public void Add(int num1)
        {
            currentValue = currentValue + num1;
        }
        public void Subtract(int num1)
        {
            currentValue = currentValue - num1;
        }
        public void Multiplication(int num1)
        {
            currentValue = currentValue * num1;
        }
        public void Division(int num1)
        {
            currentValue = currentValue / num1;
        }

    }

}
