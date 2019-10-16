using System;

namespace Lesson3
{
    public class MisCalculate : BadMath
    {
        // Constructor1
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
        // variables
        private int offset = 7;

        public override void Add(int op2)
        {
            currentValue = (currentValue + op2) + offset;
        }

        
        public override void Subtract(int op2)
        {
            currentValue = (currentValue - op2) + offset;
        }

        public override void Multiply(int op2)
        {
            currentValue = (currentValue * op2) + offset;
        }
        public override int Divide(int op2)
        {
            if (op2 == 0)
            {
                //Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                currentValue = 0;
                return 0;
            }
            else
            {
                currentValue = (currentValue / op2) + offset;
                return 1;
            }
            
        }
    }
}