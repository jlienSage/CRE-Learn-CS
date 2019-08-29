using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] palindrome = args[0].ToCharArray();
            string palindrome_str = args[0];
        
            // TODO: determine whether or not "palindrome" is, in fact, a palindrome.
            // Print a friendly message.
            Console.WriteLine ("Your input: " + "\"" + palindrome_str + "\"");
            Console.WriteLine ("# of args: " + args.Length);
            //Console.WriteLine ($"Your input: {palindrome_str}");
            int frontIndex = 0;
            int backIndex = palindrome.Length - 1;
            bool successfulMatch = true;

            // loop through each command line arg
            int inputStringIndex = 0;
            for (  ;  )
            {
                Console.WriteLine ("Your input: " + "\"" + palindrome_str + "\"");
                Console.WriteLine ("# of args: " + args.Length);
            }

            for (frontIndex = 0, backIndex = palindrome.Length - 1; 
                frontIndex < backIndex; 
                frontIndex++, backIndex--)
            {
                if (palindrome[frontIndex] == palindrome[backIndex])
                {

                }
                else
                {
                    successfulMatch = false;
                    break;
                }
            }

            if (successfulMatch)
            {
                Console.WriteLine("Yes, " + "\"" + palindrome_str + "\""  + " is a palindrome.");
            }
            else 
            {
                 Console.WriteLine("No, " + "\"" + palindrome_str + "\"" + " is not a palindrome:(");

            }

        }
    }
}
