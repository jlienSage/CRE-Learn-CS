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
            int a = 0;

            if (x >= y && x >= z) 
                {
                    a = x;
                }
            if (y >= x && y >= z)
                {
                    a = y;
                }           
            else
                {
                    a = z;
                }

            Console.WriteLine("The largest number is {0}", a);         
        }
    }
}
