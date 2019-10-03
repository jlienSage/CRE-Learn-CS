using System;

namespace Lesson3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num1 = 1.5;
            double num2 = 5;
                        
            BrokenCalculator calc = new BrokenCalculator ();

            calc.Add(num1, num2);
            Console.WriteLine($"The calculated total for addition is {calc.NewTotal}");
            
            calc.Subtract(num1, num2);
            Console.WriteLine($"The calculated total for subtraction is {calc.NewTotal}");

            calc.Multiplication(num1, num2);
            Console.WriteLine($"The calculated total for multiplication is {calc.NewTotal}");

            if (num2 == 0.0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            else
                {
                    calc.Division(num1, num2);
                    Console.WriteLine($"The calculated total for division is {calc.NewTotal}");
                }   
        }
    
    }
}



/*            
    Create a class that represents a broken calculator, how it is broken is up to you, get creative!
    - The class should be able to be configured upon initilization with a value of your choice
        that adversly affects its funcionality in some way.
        (e.g. all multiplications are off by some factor, or it prints something to the Console when certain values are entered, etc.)
    - Your calculator should have methods for multiplication, addition, subtraction and division.
    - Your calculator should have a property representing the current value, which can be cleared.

    Demonstrate your class's functionality by utilizing it within this Main() method.            
*/

//don't need input for the calculator
