
 // TODO: determine whether or not "palindrome" is, in fact, a palindrome.
 // Print a friendly message.

using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
           // creating an array of type char
            String[] newArray = {"palindrome","emordilap"};

            if (newArray[0] == newArray[1])
            {
                Console.WriteLine("palindrome is in fact a palindrome.");
                Console.WriteLine(newArray[0]+" = "+newArray[1]);
            }
            else
            {
                Console.WriteLine("No palindrome is not a palindrome.");
                 Console.WriteLine(newArray[0]+" != "+newArray[1]);
            }

            
        }
    }
}   