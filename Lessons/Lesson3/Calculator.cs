using System;

namespace Lesson3
{
    public class Calculator
    {
        public double Add(double first, double second)
        {
            double result = first + second;
            Console.WriteLine("{0} + {1} = {2}", first, second, result);
            if (first == second)
                Console.WriteLine("Why didn't you multiply by 2 silly!");
            return result;
        }

        public double Subtract(double first, double second)
        {
            double result = first - second;
            Console.WriteLine("{0} - {1} = {2}", first, second, result);
            return result;
        }

        public double Mutiply(double first, double second)
        {
            double result = first * second;
            Console.WriteLine("{0} * {1} = {2}", first, second, result);
            if (first == second)
                Console.WriteLine("You have twins!");
            // Console.WriteLine("result"); need to figure out how to multiply result by 2
            if (first != second)
            Console.WriteLine(result = result * 2);
            Console.WriteLine("You now have double trouble");
            return result;
        }

        public double Divide(double first, double second)
        {
            double result = first / second;
            Console.WriteLine("{0} / {1} = {2}", first, second, result);
            if (result < first)
                Console.WriteLine("You are greedy!");
            return result;
        } 

    }
}






