using System;

namespace Lesson3
{
    //public class MisCalculate : RichMath
    public class MisCalculate : ICalculator
    {
                
        //Consturctor - no parameters
        public  MisCalculate() 
        {
            currentValue = 500;
        }
        
        //Constructor - 1 parameter
        //Syntax error: "There is no argument given that corresponds to the 
        //required formal parameter 'initValue' of ...
         public  MisCalculate(int initValue) 
        {
            currentValue = initValue;
        }
        

        // Constructor - 2 parameters
        // Syntax error: "member names cannot be the same as their enclosing type"
        /* 
         public MisCalculate (int initValue, int initOffset)
        {
            offset = initOffset;
            base.currentValue = initValue;
        }
        */
        
        //Property
        protected decimal currentValue = 0;  //backing field

        public decimal CurrentValue
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

        // variables
        private decimal offset = 7;

        public virtual void Add(decimal op2)
        {
            // base.Add(op2 + offset);
            currentValue = (currentValue + op2) + offset;
        }

        
        public virtual void Subtract(decimal op2)
        {
            //base.Subtract(op2 + offset);
            currentValue = (currentValue - op2) + offset;
        }

        public virtual void Multiply(decimal op2)
        {
            //base.Multiply(op2 + offset);
            currentValue = (currentValue * op2) + offset;
        }

        public virtual void Divide(decimal op2)
        {
            if (op2 == 0)
            {
                //Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                //currentValue = 0;
                //return 0;
            }
            else
            {
                //base.Divide(op2 + offset);
                currentValue = (currentValue / op2) + offset;
                //return 1;
            }
            
        }

        public void Clear()
        {
            currentValue = 0;
        }
    }
}