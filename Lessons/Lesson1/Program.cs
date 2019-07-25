using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            int y = 608;
            int z = 12;
            int largestNum  = x;

            // TODO: write a set of statements that computes the largest of the above values
            // and prints it to the console in a friendly message.
            if (y > largestNum) 
            {
                largestNum = y;
            }
            if (z > largestNum)
            {
                largestNum = z;
            }

            Console.WriteLine("Largest Number is: " + largestNum);
        }
    }
}
