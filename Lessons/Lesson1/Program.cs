using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 6;
            int z = 12;




            // TODO: write a set of statements that computes the largest of the above values
            // and prints it to the console in a friendly message.


            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("X is the largest number");
                }
                else
                {
                    Console.WriteLine("Z is the largest number");
                }
            }
            else if (y > z)
            {
                Console.WriteLine("Y is the largest number");
            }
            else
            {
                Console.WriteLine("Z is the largest number");
            }



        }
    }
}
