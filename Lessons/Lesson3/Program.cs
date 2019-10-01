using System;


namespace Lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal first, second, result;
            char op;
            Calculator calculator = new Calculator();

            while (calculator.notdone)
            {
                Console.Write("Enter first value: ");
                first = Convert.ToDecimal(Console.ReadLine());
                //Console.Write("Enter second value: ");
                //second = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter operator (+, -, *, /, C, X,): ");
                string input = Console.ReadLine();
                op = input.ToCharArray()[0];


                switch (op)
                {
                    case '+':
                        result = calculator.Add(first, second);
                        Console.WriteLine("{0} + {1} = {2}", first, second, result);
                        if (first == second)
                        Console.WriteLine("Why didn't you multiply by 2 silly!");
                        break;

                    case '-':
                        result = calculator.Subtract(first, second);
                        Console.WriteLine("{0} - {1} = {2}", first, second, result);
                        break;

                    case '*':
                        result = calculator.Mutiply(first, second);
                        Console.WriteLine("{0} * {1} = {2}", first, second, result);
                        if (first == second)
                        Console.WriteLine("You have twins!");
                        if (first != second)
                        Console.WriteLine(result = result * 2);
                        break;

                    case '/':
                        result = calculator.Divide(first, second);
                        Console.WriteLine("{0} / {1} = {2}", first, second, result);
                        if (result < first)
                        Console.WriteLine("You are greedy!");
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



