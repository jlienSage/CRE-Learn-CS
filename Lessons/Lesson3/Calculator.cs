using System;


namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private decimal store = 0.0M;

        public bool notdone = true;
        public bool done = false;
        //need to break calculator across all results.
        
        public decimal Store
        {
            get { return store; }
            set
            {
                if (value != store)
                    store = value;
            }
        }


        public decimal Add(decimal first) 
        {
            Store = first + store;

            return Store;

        }

        public decimal Subtract(decimal first)
        {
            Store = store - first;
            
            return Store;
        }

        public virtual decimal Mutiply(decimal first)
        {
            Store = first * store;

            return Store;
        }
        public decimal Divide(decimal first)
        {
            Store = store / first;

            return Store;
        }

        public void Clear()
        {

            return;
        }
        public void Exit()
        {

            return;
        }

    }
}






