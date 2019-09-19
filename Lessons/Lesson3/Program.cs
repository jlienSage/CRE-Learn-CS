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
            int initOffset = 7;
            int oper0 = 1;
            int oper1 = 1;
            int oper2 = 2;
            int oper3 = 3;
            int oper4 = 0;
            int result = 0;

            BadMath myMath = new BadMath(oper0, initOffset);

            /*
                        switch (operation)
                        {
                            case "+":
                                result = myMath.Add(oper1, oper2);
                                break;
                            case "-":
                            case "*":
                            case "/":
                            case "c":
                            default:
                                break;
                        }
            */


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

            Console.WriteLine("Good-bye");
        }
    }
}
