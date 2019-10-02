﻿using System;



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
                        Store = calculator.Add(first, calculator.Store);
                        Console.WriteLine("({0} + {1} = {2})", first, calculator.Store, Store);
                        calculator.Store = Store;
                        break;

                    case '-':
                        Store = calculator.Subtract(first, calculator.Store);
                        Console.WriteLine("{0} - {1} = {2}", calculator.Store, first, Store);
                        calculator.Store = Store;
                        break;

                    case '*':
                        Store = calculator.Mutiply(first, calculator.Store);
                        Console.WriteLine("{0} * {1} = {2}", first, calculator.Store, Store);
                        calculator.Store = Store;
                        break;

                    case '/':
                        Store = calculator.Divide(first, calculator.Store);
                        Console.WriteLine("{0} / {1} = {2}", calculator.Store, first, Store);
                        calculator.Store = Store;
                        break;

                    case 'C':
                        calculator.Clear();
                        calculator.Store = 0.0M;
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



