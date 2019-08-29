using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindrome = args[2].ToCharArray();
            string palindrome_string = args[2];

            //Output the argument
            Console.WriteLine ("Your input: " + "\"" + palindrome_string + "\"");
            
            //Initialize variables
            int frontIndex = 0;
            int backIndex = palindrome.Length -1;
            bool successfulMatch = true;

            for (   
                    frontIndex = 0, backIndex = palindrome.Length -1;
                    frontIndex < backIndex;
                    frontIndex++, backIndex--
                )
                
                    {
                        if (palindrome[frontIndex] == palindrome[backIndex])
                    
                            {   
                                //do nothing
                            }
                        else
                            {
                                successfulMatch = false;
                                break;
                            }
                    }

                    if (successfulMatch == true)
                    {
                        Console.WriteLine("Yes, " + "\"" + palindrome_string + "\"" + " is a palindrome.");
                    }
                    else
                    {
                        Console.WriteLine("No, " + "\"" + palindrome_string + "\"" + " is not a palindrome");
                    }
            
        }
    }
}
