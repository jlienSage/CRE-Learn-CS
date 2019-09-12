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
            int oper0 = 100;
            int oper1 = 1;
            int oper2 = 2;
            int oper3 = 3;
            int oper4 = 4;
            int result = 0;
            //string operation = "+";

            BadMath myMath = new BadMath();
            
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

            /*
            result = myMath.Add(oper0, oper1);
            Console.WriteLine($"Addition Result: {result}");
            result = myMath.Add(myMath.CurrentValue, oper1);
            Console.WriteLine($"Addition Result: {result}");

            result = myMath.Subtract(myMath.CurrentValue, oper2);
            Console.WriteLine($"Subtraction Result: {result}");

            result = myMath.Multiply(myMath.CurrentValue, oper3);
            Console.WriteLine($"Multiplication Result: {result}");

            result = myMath.Divide(myMath.CurrentValue, oper4);
            Console.WriteLine($"Division Result: {result}");

            result = myMath.Clear();
            Console.WriteLine($"Clear Result: {result}");
            */

            Console.WriteLine($"CurrentValue: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Add(oper0, oper1);
            Console.WriteLine($"Addition Result: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Add(myMath.CurrentValue, oper1);
            Console.WriteLine($"Addition Result: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Subtract(myMath.CurrentValue, oper2);
            Console.WriteLine($"Subtraction Result: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Multiply(myMath.CurrentValue, oper3);
            Console.WriteLine($"Multiplication Result: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Divide(myMath.CurrentValue, oper4);
            Console.WriteLine($"Division Result: {myMath.CurrentValue}");

            myMath.CurrentValue = myMath.Clear();
            Console.WriteLine($"Clear Result: {myMath.CurrentValue}");
        }
    }
}
