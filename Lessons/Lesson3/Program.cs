using System;

namespace Lesson3
{
    class Program
    {
                  
         private static void Main(string[] args)
        {
            double first, second, result;
             
            Console.Write("Enter first value: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second value: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char op = (char)Console.Read();
                               
            switch(op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    if (first == second)
                    Console.WriteLine("Why didn't you multiply by 2 silly!");
                    break;
                 
                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                 
                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    if (first == second) 
                    Console.WriteLine("You have twins!");
                    if (second == result)
                    Console.WriteLine("42 is the answer of life and the wrong answer to your question!");
                    break;
                 
                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    if (result < first) 
                    Console.WriteLine("You are greedy!");
                    break;
 
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
                        
            }
        }
    }
}
        

        
