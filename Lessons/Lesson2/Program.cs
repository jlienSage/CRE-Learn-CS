using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var palindrome = args[0].ToCharArray();
            
            // TODO: determine whether or not "palindrome" is, in fact, a palindrome.
            // Print a friendly message.
            int frontIndex = 0;
            int backIndex = palindrome.Length - 1;             
            
            bool successfulMatch = true;

            //for (int i = 0; i < palindrome.Length +1; i++);
            //Console.Write (palindrome.Length); //Need to get the array lengthe for args so I can count the args.
                
            for (frontIndex = 0, backIndex = palindrome.Length - 1; 
                frontIndex < backIndex; 
                frontIndex++, backIndex--)

            {
                if (palindrome[frontIndex] == palindrome[backIndex])
                {

                }
                else
                {
                    successfulMatch = false;
                    break;
                }
            }

            if (successfulMatch)
            {
                Console.WriteLine($"Yes, {args[0]} is a palindrome.");
            }
            else 
            {
                 Console.WriteLine($"No, {args[0]}  is not a palindrome");

            }
        }
    }
}

    
      
    
    

