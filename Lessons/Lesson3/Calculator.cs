using System;

namespace Lesson3
{
    public class Calculator
    {
        protected double currentValue = 0;
        public double newTotal
        {
            get
            {
                return currentValue;
            }
        }

        public virtual void Add(int num1)
        {
            currentValue = currentValue + num1;
        }
        public virtual void Subtract(int num1)
        {
            currentValue = currentValue - num1;
        }
        public virtual void Multiplication(int num1)
        {
            currentValue = currentValue * num1;
        }
        public virtual int Division(int num1)
        {
            if (num1 == 0)
            {
                return 0;
            }
            else
            {
                currentValue = currentValue / num1;
                return 1;
            }
            
        }
        public void Clear()
        {
            currentValue = 0;
        }

    }

}
