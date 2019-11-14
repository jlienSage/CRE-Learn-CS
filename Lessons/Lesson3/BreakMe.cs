using System;


namespace Lesson3
{
    public class BreakMe : ICalculator
    {
        // private field backing field
        private decimal store = 0.0M;
        public decimal CurrentValue
        {
            get { return store; }
            set
            {
                if (value != store)
                    store = value;
            }
        }
        public virtual void Multiply(decimal first)
        {
            CurrentValue = first + 25;
            //return Subtract(first);
        }
        public virtual void Add(decimal first)
        {
            CurrentValue = first - 25;
            //return Subtract(first);
        }
        public virtual void Subtract(decimal first)
        {
            CurrentValue = first + 25;
            //return Subtract(first);
        }
        public virtual void Divide(decimal first)
        {
            CurrentValue = store / first;
            //   return Store;
        }
        public void Clear()
        {
            store = 0.0M;

            return;
        }

    }
}
