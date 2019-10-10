using System;



namespace Lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal first;
            char op;
            //Calculator calculator = new Calculator();  //Replace globally breakme with calculator to fix my calculator.
            BreakMe breakme = new BreakMe();

            while (breakme.notdone)
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
                        breakme.Add(first);
                        Console.WriteLine("{0}", breakme.Store);
                        break;

                    case '-':
                        breakme.Subtract(first);
                        Console.WriteLine("{0}", breakme.Store);
                        break;

                    case '*':
                        breakme.Multiply(first);
                        Console.WriteLine("{0}", breakme.Store);
                        break;

                    case '/':
                        breakme.Divide(first);
                        Console.WriteLine("{0}", breakme.Store);
                        break;

                    case 'C':
                        breakme.Clear();
                        Console.WriteLine("Result has been cleared");
                        break;

                    case 'X':
                        breakme.notdone = false;
                        Console.WriteLine("Program has exited");
                        return;

                    default:
                        break;
                }
            }
        }
    }
}



