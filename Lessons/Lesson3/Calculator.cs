using System;


namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private decimal store = 0.0M;

        //public decimal breakme = calculator.Store*10;

        public decimal Store
        {
            get { return store; }
            set
            {
                if (value != store)
                    store = value;
            }
        }
        public decimal result;

        //need to break calculator across all results.
        public bool notdone = true;

        public decimal Add(decimal first, decimal store) //decimal second)
        {
            result = first + store;

            return result;


        }

        public decimal Subtract(decimal first, decimal store)
        {
            result = store - first;

            return result;
        }

        public decimal Mutiply(decimal first, decimal store)
        {
            result = first * store;

            return result;
        }
        public decimal Divide(decimal first, decimal store)
        {
            result = store / first;

            return result;
        }

        public void Clear()
        {
            Console.WriteLine("Result has been cleared");
            return;
        }
        public void Exit()
        {
            notdone = false;

            Console.WriteLine("Program has exited");
            return;
        }

    }
}






