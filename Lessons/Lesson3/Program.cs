using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Part 1:           
                    Create a class that represents a broken calculator, how it is broken is up to you, get creative!
                    - The class should be able to be configured upon initilization with a value of your choice
                        that adversly affects its funcionality in some way.
                        (e.g. all multiplications are off by some factor, or it prints something to the Console when certain values are entered, etc.)
                    - Your calculator should have methods for multiplication, addition, subtraction and division.
                    - Your calculator should have a property representing the current value, which can be cleared.
                
                Part 2:
                    Create a calculator base class without the broken functionality and extend the class with a new class that
                    overrides the functionality with your broken functionality. This should mostly be refactoring, no new behavior.
                    You are NOT allowed to modify your demonstration in this method, it should still compile and run.

                Demonstrate your class's functionality by utilizing it within this Main() method.
            */
            int offset = 0;
            int initialValue = 0;    //for initial value
            int oper1 = 1;           //for add
            int oper2 = 2;           //for subtract
            int oper3 = 3;           //for multiply
            int oper4 = 4;           //for divide

            //BadMath myMath = new BadMath(oper0);
            RichMath myMath = new MisCalculate();

            //myMath.initValue(oper0);
            Console.WriteLine($"CurrentValue: {myMath.CurrentValue}");

            myMath.Add(oper1);
            Console.WriteLine($"Addition Result: {myMath.CurrentValue}");

            myMath.Subtract(oper2);
            Console.WriteLine($"Subtraction Result: {myMath.CurrentValue}");

            myMath.Multiply(oper3);
            Console.WriteLine($"Multiplication Result: {myMath.CurrentValue}");

            //myMath.Divide(oper4);
            if (myMath.Divide(oper4) == 0)
            {
                Console.WriteLine("ERROR: Divide by 0");
            }
            else
            {
                Console.WriteLine($"Division Result: {myMath.CurrentValue}");
            }
           
            myMath.Clear();
            Console.WriteLine($"Clear Result: {myMath.CurrentValue}");

        }
    }
}
