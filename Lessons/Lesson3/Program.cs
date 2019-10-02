using System;



namespace Lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal first, Store;
            char op;
            Calculator calculator = new Calculator();

            while (calculator.notdone)
            {
                Console.Write("Enter value: ");
                first = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter operator (+, -, *, /, C, X,): ");
                Console.Write("Enter second value: ");
                string input = Console.ReadLine();
                op = input.ToCharArray()[0];
               

                switch (op)
                {
                    case '+':
                        Store = calculator.Add(first, calculator.Store); 
                        Console.WriteLine("{0} + {1} = {2}", first, calculator.Store, Store);
                        calculator.Store=Store;
                        break;
                
/*
                    case '-':
                        result = calculator.Subtract(first, second);
                        Console.WriteLine("{0} - {1} = {2}", first, second, result);
                        break;

                    case '*':
                        result = calculator.Mutiply(first, second);
                        Console.WriteLine("{0} * {1} = {2}", first, second, result);
                        break;

                    case '/':
                        result = calculator.Divide(first, second);
                        Console.WriteLine("{0} / {1} = {2}", first, second, result);
                       break;

                   case 'C':
                    calculator.Clear();
                     break;

                    case 'X':
                        calculator.Exit();
                        break;

*/
                    default:
                        break;
                }
            }
        }
    }
}



