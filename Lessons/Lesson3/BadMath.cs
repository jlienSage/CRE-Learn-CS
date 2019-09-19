using System;

namespace Lesson3
{

    // look into field, property and backing variable.

    public class BadMath
    {
        // Constructor
        public BadMath(int initValue, int initOffset)
        {
            offset = initOffset;
            currentValue = initValue;
        }

        //Property
        private int currentValue = 0;  //backing field
        private int offset = 0;
        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            //set
            //{
            //    currentValue = value;
            //}
        }

        
        public void initValue(int op2)
        {
            currentValue = op2;
        }
            
            public void Add(int op2)
        {
            currentValue = currentValue + op2 + offset;
        }

        //All methods return a bad value by adding 7 to the result.
        public void Subtract(int op2)
        {
            currentValue = currentValue - op2 + offset;
        }

        public void Multiply(int op2)
        {
            currentValue = currentValue * op2 + offset;
        }
        public void Divide(int op2)
        {
            if (op2 == 0)
            {
                Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                op2 = 1;
            }
            currentValue = currentValue / op2 + offset;
        }
        public void Clear()
        {
            currentValue = 0;
        }

    }

}

