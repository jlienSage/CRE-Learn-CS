using System;


namespace Lesson3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            double first, second, result;

            Console.Write("Enter first value: ");
            char op; 
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second value: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();
            
            
            Calculator calculator = new Calculator();
            
            switch (op)
            {
                case '+':
                    result = calculator.Add( first, second);
                    break;

                case '-':
                    result = calculator.Subtract( first, second);
                   break;

                case '*':
                    result = calculator.Mutiply( first, second);
                    break;

                case '/':
                     result = calculator.Divide( first, second);

                    break;

                default:
                    break;
            }
        }
    }
}



