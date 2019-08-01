
using System;

namespace Lesson1
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            int x = -1;
            int y = 608;
            int z = 12;

            // TODO: write a set of statements that computes the largest of the above values
            // and prints it to the console in a friendly message.

                if (x > y || x > z)
                {
                    if (y > x || y > z)
                    {

                        Console.WriteLine(x+y);

                    }
                
                }
                else
                {
                    Console.WriteLine(z+y);
                }
        }
            
    }
}
