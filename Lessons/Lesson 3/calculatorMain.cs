using System;

namespace Lesson
{
class calculatorMain
{
    public static void main(String args[])
    {
        //no input error trapping necessary
        
        //initalizng variables
        int a = 0;
        int b = 0;
        int menuOption = 0;
        Boolean flag = true;
        
        calculatorBackEnd myCalculator = new calculatorBackEnd();
        
        //creating scanner object to capture user inputs
        
        
        Console.WriteLine("Welcome to your calculator!");
        
        while (flag)
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter a operation you'd like to do:");
            Console.WriteLine("Enter '1' for addition");
            Console.WriteLine("Enter '2' for subtraction");
            Console.WriteLine("Enter '3' for multiplication");
            Console.WriteLine("Enter '4' for division");
            Console.WriteLine("Enter '5' to exit program");
            Console.WriteLine("");
            menuOption = int.Parse(Console.ReadLine());
            
            switch (menuOption)
            {
                case 1:
                Console.WriteLine("Addition operation selected");
                myCalculator.addition(a,b);
                break;
                
                case 2:
                Console.WriteLine("Subtraction operation selected");
                myCalculator.subtraction(a,b);
                break;
                
                case 3: 
                Console.WriteLine("Multiplication operation selected");
                myCalculator.multiplication(a,b);
                break;
                
                case 4:
                Console.WriteLine("Division operation selected");
                myCalculator.division(a,b);
                break;
                
                case 5:
                Console.WriteLine("Exiting program...");
                flag = false;
                break;
                
                default:
                Console.WriteLine("Invalid input. Please select options 1 - 4 to continue using calculator or 5 to exit program.");
                break;
            }
            

        
        }
        Console.WriteLine("Thank you for using the calculator!");
    }

} 
} 
