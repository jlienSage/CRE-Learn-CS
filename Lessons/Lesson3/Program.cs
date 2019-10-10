using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
                Create a class that represents a broken calculator, how it is broken is up to you, get creative!
                - The class should be able to be configured upon initilization with a value of your choice
                    that adversly affects its funcionality in some way.
                    (e.g. all multiplications are off by some factor, or it prints something to the Console when certain values are entered, etc.)
                    This configuration should be accessible outside the class BUT NOT MODIFIABLE.
                - Your calculator should have methods for multiplication, addition, subtraction and division.
                - Your calculator should have a property representing the current value, which can be cleared.

                Demonstrate your class's functionality by utilizing it within this Main() method.
            */
            int offset = 0;
            int oper0 = 0;      //for initial value
            int oper1 = 100;      //for add
            int oper2 = 2;      //for subtract
            int oper3 = 3;      //for multiply
            int oper4 = 4;      //for divide

            //BadMath myMath = new BadMath(oper0);
            //initialize starting value to non-zero
            MisCalculate myMisCalc = new MisCalculate();


            /*
            Console.WriteLine("Good Math Results:");
            myClass.PrintMessage();

            //myMath.initValue(oper0);
            Console.WriteLine($"CurrentValue: {myMath.CurrentValue}");

            myMath.Add(oper1);
            Console.WriteLine($"Addition Result: {myMath.CurrentValue}");

            myMath.Subtract(oper2);
            Console.WriteLine($"Subtraction Result: {myMath.CurrentValue}");

            myMath.Multiply(oper3);
            Console.WriteLine($"Multiplication Result: {myMath.CurrentValue}");

            myMath.Divide(oper4);
            Console.WriteLine($"Division Result: {myMath.CurrentValue}");

            myMath.Clear();
            Console.WriteLine($"Clear Result: {myMath.CurrentValue}");
*/
            //BAD MATH
            Console.WriteLine("Bad Math Results:");
            Console.WriteLine($"CurrentValue: {myMisCalc.CurrentValue}");

            myMisCalc.Add(oper1);
            Console.WriteLine($"Addition Result: {myMisCalc.CurrentValue}");

            myMisCalc.Subtract(oper2);
            Console.WriteLine($"Subtraction Result: {myMisCalc.CurrentValue}");

            myMisCalc.Multiply(oper3);
            Console.WriteLine($"Multiplication Result: {myMisCalc.CurrentValue}");

            myMisCalc.Divide(oper4);
            Console.WriteLine($"Division Result: {myMisCalc.CurrentValue}");

            myMisCalc.Clear();
            Console.WriteLine($"Clear Result: {myMisCalc.CurrentValue}");
            Console.WriteLine("Good-bye");
        }

    }


        /* 
        public class TestClass
        {
            public void PrintMessage()
            {
                Console.WriteLine("this is TestClass");
            }
        }
        */
}
