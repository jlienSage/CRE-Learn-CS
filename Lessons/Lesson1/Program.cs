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
      
			if (x>=y && x>=z)
			{
				Console.WriteLine($"{x} is the largest number");
			}
			else if (y>=z)
			{
				Console.WriteLine($"{y} is the largest number");
			}
			else
			{
				Console.WriteLine($"{z} is the largest number");
			}
        }         
    }
}
