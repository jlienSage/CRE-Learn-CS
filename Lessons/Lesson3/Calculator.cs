using System;

namespace Lesson3

{
    public class Calculator
    {
        public void add(string sign, int num1, int num2, int total)
        {
            if (sign == "addition")
            {
                total = num1 + num2;
            }
        }
        public void subtract(string sign, int num1, int num2, int total)
        {
            if (sign == "subtraction")
            {
                total = num1 - num2;
            }
        }
        public void multiplication(string sign, int num1, int num2, int total)
        {
            if (sign == "multiplication")
            {
                total = num1 * num2;
            }
        }
         public void division(string sign, int num1, int num2, int total)
        {
            if (sign == "division")
            {
                total = num1 * num2;
            }           
        }

//need to handle invalid sign
        
    }

}