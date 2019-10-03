using System;

namespace Lesson3
{
    public class BrokenCalculator
    {
        private double currentValue = 0;
        public double NewTotal
        {
            get
            {
                return currentValue;
            }
        }

        public void Add(double num1, double num2)
        {
            currentValue = num1 + num2;
        }
        public void Subtract(double num1, double num2)
        {
            currentValue = num1 - num2;
        }
        public void Multiplication(double num1, double num2)
        {
            currentValue = num1 * num2;
        }
        public void Division(double num1, double num2)
        {
            currentValue = num1 / num2;
        }

    }

}

//change the calculator so you enter each value individually like a new calculator
//add a private field to use the break the calculator