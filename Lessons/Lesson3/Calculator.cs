using System;

namespace Lesson3
{
    public class Calculator : ICalculator
    {
        private decimal currentValue = 0;
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
        }

        public virtual void Add(decimal x)
        {
            currentValue = currentValue + x;
        }
        public virtual void Subtract(decimal x)
        {
            currentValue = currentValue - x;
        }
        public virtual void Multiply(decimal x)
        {
            currentValue = currentValue * x;
        }
        public virtual void Divide(decimal x)
        {
            currentValue = currentValue / x;
        }
    /*     {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                currentValue = currentValue / num1;
                return 1;
            }
            
        }
        */
        public void Clear()
        {
            currentValue = 0;
        }

    }

}
