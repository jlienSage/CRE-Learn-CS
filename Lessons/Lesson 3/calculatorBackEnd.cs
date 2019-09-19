using System;

namespace Lesson
{
class CalculatorBackEnd
{
    
    
    int Result = 0;
    

   
    public void addition(int FirstInput, int SecondInput)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        FirstInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        SecondInput = int.Parse(Console.ReadLine());
        
        //program incorrectly adds 1 to the sum
        Result = (FirstInput + SecondInput + 1);
        Console.WriteLine("Here's the sum of the two integers: " + Result);
        
    }   
    
    public void subtraction(int FirstInput, int SecondInput)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        FirstInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        SecondInput = int.Parse(Console.ReadLine());
        
        //incorrectly subtracts b from a instead of a from b.
        Result = (SecondInput - FirstInput);
        Console.WriteLine("Here's the difference of the two integers: "+ Result);
        
    }
    
    
    public void multiplication(int FirstInput, int SecondInput)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        FirstInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        SecondInput = int.Parse(Console.ReadLine());
        
        //incorrectly multiplies the sum by 10X what it should be
        Result = (FirstInput * SecondInput * 10);
        Console.WriteLine("Here's the product of the two integers: "+ Result);
        
    }
    
    public void division(int FirstInput, int SecondInput)
    {
        Console.WriteLine("Now please enter 2 inputs to begin your operation:");
        Console.WriteLine("");
        Console.WriteLine("Enter first input:");
        FirstInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second input: ");
        SecondInput = int.Parse(Console.ReadLine());
    if (SecondInput != 0)
    {
        //this is actually correct :)
        Result = (FirstInput / SecondInput);
        Console.WriteLine("Here's the quotient of the two integers: "+ Result);
    }
    else
    {
        Console.WriteLine("Error! Cannot divide by '0'! Please clear calculator.");

    }  
    }
}
}
