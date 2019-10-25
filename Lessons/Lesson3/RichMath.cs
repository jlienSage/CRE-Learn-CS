using System;

namespace Lesson3
{
    // look into field, property and backing variable.

    public class RichMath
    {
        //Consturctor - 0 parameter
        public RichMath ()
        {
            currentValue = 0;
        }
        
        //Consturctor - 1 parameter
        /*
        public RichMath (int initValue)
        {
            currentValue = initValue;
        }
        */

        // Constructor - 2 parameters
        // Syntax error: "member names cannot be the same as their enclosing type"
        /* 
        public void RichMath(int initValue, int initOffset)
        {
            offset = initOffset;
            base.currentValue = initValue;
        }
        */



        //Property
        protected int currentValue = 0;  //backing field
        //private int currentValue = 0;  //backing field

        private int offset = 0;
        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            //set - for later use
            /*
            {
                currentValue = value;
            }
            */
        }

        
        public void InitValue(int op2)
        {
            currentValue = op2;
        }
        
            
        public virtual void Add(int op2)
        {
            currentValue = currentValue + op2;
        }

        public virtual void Subtract(int op2)
        {
            currentValue = currentValue - op2;
        }

        public virtual void Multiply(int op2)
        {
            currentValue = currentValue * op2;
        }
        public virtual int Divide(int op2)
        {
            if (op2 == 0)
            {
                //Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                currentValue = 0;
                return 0;
            }
            else
            {
                currentValue = currentValue / op2;
                return 1;
            }
        }
        public void Clear()
        {
            currentValue = 0;
        }

    }

}

