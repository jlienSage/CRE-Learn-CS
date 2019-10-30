namespace Lesson3
{
    using System;

    public class BrokenCalculator : Calculator
    {
        private readonly decimal moduloValue;

        public BrokenCalculator(int resetIfDivisibleBy)
        {
            moduloValue = (decimal)resetIfDivisibleBy;
        }

        public override void Add(decimal x)
        {
            ResetIfModuloZero(x);
            base.Add(x);
        }

        public override void Subtract(decimal x)
        {
            ResetIfModuloZero(x);
            base.Subtract(x);
        }

        public override void Multiply(decimal x)
        {
            ResetIfModuloZero(x);
            base.Multiply(x);
        }

        public override void Divide(decimal x)
        {
            ResetIfModuloZero(x);
            base.Divide(x);
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