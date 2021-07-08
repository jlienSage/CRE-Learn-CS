using System;

namespace Lesson
{
public class CalculatorBackEnd
{
    
    
    
    

    public void Clear(double Result)
    {
        //clearing calculator
        Result = 0;


    }
    
    
    public void Addition(int FirstInput, int SecondInput, double Result)
    {
        
        //program incorrectly adds 1 to the sum
        Result = (FirstInput + SecondInput + 1);
        Console.WriteLine("Here's the sum of the two integers: " + Result);
        
    }   
    
    public void Subtraction(int FirstInput, int SecondInput, double Result)
    {
 
        //incorrectly subtracts b from a instead of a from b.
        Result = (SecondInput - FirstInput);
        Console.WriteLine("Here's the difference of the two integers: "+ Result);
        
    }
    
    
    public void Multiplication(int FirstInput, int SecondInput, double Result)
    {
        //incorrectly multiplies the sum by 10X what it should be
        Result = (FirstInput * SecondInput * 10);
        Console.WriteLine("Here's the product of the two integers: "+ Result);
    }
    
    public void Division(int FirstInput, int SecondInput, double Result)
    {

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
