using System;

namespace Lesson3
{
    public class MisCalculate : BadMath
    {
        // Constructor
        /* public MisCalculate (int initValue, int initOffset)
        {
            offset = initOffset;
            currentValue = initValue;
        }
        */

        /* 
        public MisCalculate ()
        {
            currntValue = 7;
        }
        */

        public override void Add(int op2)
        {
            currentValue = 77;
        }

        
        public void Subtract(int op2)
        {
            currentValue = 88;
        }

        public void Multiply(int op2)
        {
            currentValue = 99;
        }
        public void Divide(int op2)
        {
            if (op2 == 0)
            {
                Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                op2 = 1;
            }
            currentValue = 100;
        }
    }
}