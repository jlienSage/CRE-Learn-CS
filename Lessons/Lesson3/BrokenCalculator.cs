namespace Lesson3
{
    using System;

    public class BrokenCalculator
    {
        private readonly decimal moduloValue;
        private decimal currentValue;

        public BrokenCalculator(int resetIfDivisibleBy)
        {
            moduloValue = (decimal)resetIfDivisibleBy;
        }

        public decimal CurrentValue => currentValue;

        public void Add(decimal x)
        {
            ResetIfModuloZero(x);
            currentValue += x;
        }

        public void Subtract(decimal x)
        {
            ResetIfModuloZero(x);
            currentValue -= x;
        }

        public void Multiply(decimal x)
        {
            ResetIfModuloZero(x);
            currentValue *= x;
        }

        public void Divide(decimal x)
        {
            if(x == 0M)
            {
                throw new ArgumentException("Doh! Divide by zero...");
            }

            ResetIfModuloZero(x);
            currentValue /= x;
        }

        public void Clear()
        {
            currentValue = 0M;
        }

        private void ResetIfModuloZero(decimal x)
        {
            var rounded = Math.Round(x);
            var moduloZero = rounded % moduloValue == 0M;
            if(moduloZero)
            {
                Clear();
            }
        }
    }
}