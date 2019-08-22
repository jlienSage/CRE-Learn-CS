<<<<<<< HEAD
﻿// TODO: determine whether or not "palindrome" is, in fact, a palindrome.
=======
// TODO: determine whether or not "palindrome" is, in fact, a palindrome.
>>>>>>> fbed8c68348e792f889a67c6ef1af516cd1c1843
// Print a friendly message.
using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating input portion for string a
           string a = string.Empty;
           Console.WriteLine("Please enter a string:");
           a = Console.ReadLine();

            //creating my array of char
            //reversing string
           char[] palindrome = a.ToCharArray();
           Array.Reverse(palindrome);
           string b = new string(palindrome);


            //comparing the strings.. outputting friendly message
           if (a==b)
           {
                Console.WriteLine("Yes, the text entered is a palindrome");        

           }
           else
           {
                Console.WriteLine("No, the text entered is not a palindrome.");

           }
            
        }

    }
}