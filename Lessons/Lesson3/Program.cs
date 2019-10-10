using System;

namespace Lesson3
{
    class Program
    {
        public static void Main(string[] args)
        {                       
            BrokenCalculator calc = new BrokenCalculator ();

            calc.Add(14);
            calc.Subtract(2);
            calc.Multiplication(2);

            int num1 = 5;

            if (num1 == 0.0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            else
                {
                    calc.Division(num1);
                } 
        }
    }
}
/*
                Part 2:
                    Create a calculator base class without the broken functionality and extend the class with a new class that
                    overrides the functionality with your broken functionality. This should mostly be refactoring, no new behavior.
                    You are NOT allowed to modify your demonstration in this method, it should still compile and run.
                Demonstrate your class's functionality by utilizing it within this Main() method.

*/