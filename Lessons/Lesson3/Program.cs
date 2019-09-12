using System;

namespace Lesson3
{
    class Program       
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator ();
            calc.Add(10);
            calc.Multiply(2);
            calc.Subtract(25);
            calc.Divide(4);


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



    
        }



        
    }
}
