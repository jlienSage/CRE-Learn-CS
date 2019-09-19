using System;

namespace Lesson
{
class Program
{
    public static void Main(string[] args)
    {
        //no input error trapping necessary
        
        //initalizng variables
        int FirstInput = 0;
        int SecondInput = 0;
        int MenuOption = 0;
        Boolean flag = true;
        
        CalculatorBackEnd myCalculator = new CalculatorBackEnd();
        
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
            MenuOption = int.Parse(Console.ReadLine());
            
            switch (MenuOption)
            {
                case 1:
                Console.WriteLine("Addition operation selected");
                myCalculator.addition(FirstInput,SecondInput);
                break;
                
                case 2:
                Console.WriteLine("Subtraction operation selected");
                myCalculator.subtraction(FirstInput,SecondInput);
                break;
                
                case 3: 
                Console.WriteLine("Multiplication operation selected");
                myCalculator.multiplication(FirstInput,SecondInput);
                break;
                
                case 4:
                Console.WriteLine("Division operation selected");
                myCalculator.division(FirstInput,SecondInput);
                break;
                
                case 5:
                Console.WriteLine("Exiting program...");
                flag = false;
                break;

                case 6:
                Console.WriteLine("Clearning calculator...");
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
