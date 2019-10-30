namespace Lesson3
{
    using System;

    public class Calculator
    {
        public decimal CurrentValue { get; protected set; }

        public virtual void Add(decimal x)
        {
            CurrentValue += x;
        }

        public virtual void Subtract(decimal x)
        {
            CurrentValue -= x;
        }

        public virtual void Multiply(decimal x)
        {
            CurrentValue *= x;
        }

        public virtual void Divide(decimal x)
        {
            if(x == 0M)
            {
                throw new ArgumentException("Doh! Divide by zero...");
            }

            CurrentValue /= x;
        }

        public void Clear()
        {
            CurrentValue = 0M;
        }
    }
}