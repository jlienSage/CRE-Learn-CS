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

            int largest = x;

            if (y > largest)
            {
                largest = y;
            }

            if (z > largest)
            {
                largest = z;
            }

            Console.WriteLine($"The largest is {largest}.");
        }
    }
}
