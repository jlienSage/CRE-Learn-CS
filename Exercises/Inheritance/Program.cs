using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();
            people.Add(new Chris());
            people.Add(new John());
            people.Add(new Lisa());
            people.Add(new Rich());
            
            foreach(var person in people)
            {
                if(person is Chris chris)
                    Console.WriteLine(chris.Department);
                Console.WriteLine(person.ToString());
            }
        }
    }
}
