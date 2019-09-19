using System;

namespace Lesson3
{
    public class Calculator
    {
        // private field backing field
        private double result = 0.0;
        public bool notdone = true;

        public double Add(double first, double second)
        {
            result = first + second * 4;
            Console.WriteLine("{0} + {1} = {2}", first, second, result);
            if (first == second)
                Console.WriteLine("Why didn't you multiply by 2 silly!");
            return result;
        }

        public double Subtract(double first, double second)
        {
            result = first - second + 21;
            Console.WriteLine("{0} - {1} = {2}", first, second, result);
            return result;
        }

        public double Mutiply(double first, double second)
        {
            result = first * second / 4;
            Console.WriteLine("{0} * {1} = {2}", first, second, result);
            if (first == second)
                Console.WriteLine("You have twins!");
            if (first != second)
                Console.WriteLine(result = result * 2);
            //Console.WriteLine("You now have double trouble");
            return result;
        }

        public double Divide(double first, double second)
        {
            result = first / second * 2;
            Console.WriteLine("{0} / {1} = {2}", first, second, result);
            if (result < first)
                Console.WriteLine("You are greedy!");
            return result;
        }

        public void Clear()
        {
            result = 0.0;

            Console.WriteLine("Result has been cleared");
            return;
        }
        public void Exit()
        {
            notdone = false;

            Console.WriteLine("Program has exited");
            return;
        }

    }
}






