using System;


namespace Lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double first, second, result;
            char op;
            Calculator calculator = new Calculator();

            while (calculator.notdone)
            {
                Console.Write("Enter first value: ");
                first = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second value: ");
                second = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operator (+, -, *, /, C, X,): ");
                op = (Char)Console.Read();
                string fake = Console.ReadLine(); // gobble carriage return


                switch (op)
                {
                    case '+':
                        result = calculator.Add(first, second);
                        break;

                    case '-':
                        result = calculator.Subtract(first, second);
                        break;

                    case '*':
                        result = calculator.Mutiply(first, second);
                        break;

                    case '/':
                        result = calculator.Divide(first, second);
                        break;

                    case 'C':
                        calculator.Clear();
                        break;

                    case 'X':
                        calculator.Exit();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}



