using System;

namespace Lesson
{
class calculatorBackEnd
{
    
    
    int c = 0;
    

   
    public void addition(int a, int b)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        b = int.Parse(Console.ReadLine());
        
        //program incorrectly adds 1 to the sum
        c = (a + b + 1);
        Console.WriteLine("Here's the sum of the two integers: " + c);
        
    }   
    
    public void subtraction(int a, int b)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        b = int.Parse(Console.ReadLine());
        
        //incorrectly subtracts b from a instead of a from b.
        c = (b - a);
        Console.WriteLine("Here's the difference of the two integers: "+ c);
        
    }
    
    
    public void multiplication(int a, int b)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        b = int.Parse(Console.ReadLine());
        
        //incorrectly multiplies the sum by 10X what it should be
        c = (a * b * 10);
        Console.WriteLine("Here's the product of the two integers: "+ c);
        
    }
    
    public void division(int a, int b)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        b = int.Parse(Console.ReadLine());
    
        //this is actually correct :)
        c = (a / b);
        Console.WriteLine("Here's the quotient of the two integers: "+ c);
        
    }
}
}
