namespace Lesson3
{
    using System;

    public interface ICalculator
    {
        decimal CurrentValue { get; }

        void Add(decimal x);

        void Subtract(decimal x);

        void Multiply(decimal x);

        void Divide(decimal x);

        void Clear();
    }    
}