using System;
using Exercise;

namespace new_folder1
{
    class Program
   {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Person person1 = new Person("", "");
            Person person1 = new Person();

            person1.HairColor = "brunette";

            Console.WriteLine ("Name: " + person1.Name);
            Console.WriteLine ("Hair Color: " + person1.HairColor);

        }
    }
}
