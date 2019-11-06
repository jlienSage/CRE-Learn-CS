using System;

namespace Lesson3
{
    public class MisCalculate : RichMath
    {
                
        //Consturctor - no parameters
        public  MisCalculate() 
        {
            base.currentValue = 500;
        }
        
        //Constructor - 1 parameter
        //Syntax error: "There is no argument given that corresponds to the 
        //required formal parameter 'initValue' of ...
         public  MisCalculate(int initValue) 
        {
            base.currentValue = initValue;
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
        


        // variables
        private int offset = 7;

        public override void Add(int op2)
        {
            base.Add(op2 + offset);
        }

        
        public override void Subtract(int op2)
        {
            base.Subtract(op2 + offset);
        }

        public override void Multiply(int op2)
        {
            base.Multiply(op2 + offset);
        }
        public override int Divide(int op2)
        {
            if (op2 == 0)
            {
                //Console.WriteLine("Error: Can't Divide by 0; Setting Divisor to \"1\"");
                //currentValue = 0;
                return 0;
            }
            else
            {
                base.Divide(op2 + offset);
                return 1;
            }
            
        }
    }
}