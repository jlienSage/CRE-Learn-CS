using System;


namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private decimal store = 0.0M;

        public decimal Store
        {
            get { return store; }
            set
            {
                if (value != store)
                    store = value;
            }
        }


        public virtual decimal Add(decimal first)
        {
            Store = first + store;

            return Store;

        }

        public virtual decimal Subtract(decimal first)
        {
            Store = store - first;

            return Store;
        }

        public virtual decimal Multiply(decimal first)
        {
            Store = first * store;

            return Store;
        }
        public virtual decimal Divide(decimal first)
        {
            Store = store / first;

            return Store;
        }

        public void Clear()
        {
            store = 0.0M;

            return;
        }
    }
}






