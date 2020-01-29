using System;

namespace Lesson3
{
    class Program
    {
        public static void Main(string[] args)
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

                Part 3:
                    Refactor both of your calculator classes to implement the provided interface, instead of using inheritance.
                    Then, uncomment the following lines and modify ONLY lines 28 and 30 in this Main() method to create instances of your classes and pass them to the private method.
            */
            
            ICalculator calculator = new Calculator();
            DoCalculator(calculator);
            calculator = new BadCalculation();
            DoCalculator(calculator);    
                                        
        }

        private static void DoCalculator(ICalculator calculator)
        {
            calculator.Add(3);
            var currVal = calculator.CurrentValue;
            Console.WriteLine($"Current value is: {currVal}");
            calculator.Subtract(2);
            currVal = calculator.CurrentValue;
            Console.WriteLine($"Current value is: {currVal}");
            calculator.Divide(4);
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

            /* 
                        int num1 = 5;

                        if (num1 == 0.0)
                            {
                                Console.WriteLine("Cannot divide by zero");
                            }
                        else
                            {
                                calc.Division(num1);
                            } 
            */