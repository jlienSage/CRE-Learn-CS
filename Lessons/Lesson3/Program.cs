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

                //decimal breakme = (10);

                switch (op)
                {
                    case '+':
                        // value before = current value
                        // calculator add (input value)
                        // print to console "input value + value before = current value"

                        calculator.Add(first);
                        Console.WriteLine("{0}", calculator.Store);
                        break;

                    case '-':
                        calculator.Subtract(first);
                        Console.WriteLine("{0}", calculator.Store);
                        break;

                    case '*':
                        calculator.Mutiply(first);
                        Console.WriteLine("{0}", calculator.Store);
                        break;

                    case '/':
                        calculator.Divide(first);
                        Console.WriteLine("{0}", calculator.Store);
                        break;

                    case 'C':
                        calculator.Clear();
                        calculator.Store = 0.0M;
                        Console.WriteLine("Result has been cleared");
                        break;

                    case 'X':
                        calculator.Exit();
                        Console.WriteLine("Program has exited");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}



