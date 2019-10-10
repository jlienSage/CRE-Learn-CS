using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();
            // TODO add people
            
            foreach(var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
