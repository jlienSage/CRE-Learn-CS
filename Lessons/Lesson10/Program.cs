using System;

namespace DataStructure
{
   public partial class Program
    {
        static void Main(string[] args)
        {
            // Datastructe Implementation in C#

            Lesson10.Array();
            Lesson10.ArrayList();
            Lesson10.List();
            Lesson10.LinkedList();
            Lesson10.Hashtable();
            Lesson10.Dictionary();
            Lesson10.HashSet();
            Lesson10.Stack();
            Lesson10.Queue();

            // Extension method example:            
            object x = new DateTime(2020,1,2);
            // var y = (DateTime)x;
            var success = x.TryCast<DateTime>(out var z);
            if(success)
            {
                Console.WriteLine("yay.");
            }
        }
    }
}
