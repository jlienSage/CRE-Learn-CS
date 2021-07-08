using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array of char with parameter past into args
            char[]checkPalindrome = args[0].ToCharArray();

            //initalizing variables
            int backOfArray = checkPalindrome.Length-1;
            int i =0;
            Boolean flag = true;

            while(flag)
            {
              if(checkPalindrome[i]==checkPalindrome[backOfArray])  
              {
                 if (i==checkPalindrome.Length-1 && backOfArray==0)
                 {
                    Console.WriteLine("Yes the text entered is a palindrome");
                    flag = false;
                 }
                 
                  i++;
                  backOfArray--;
                   
              } 
              else
              {
                  Console.WriteLine("No the text entered is not a palindrome");
                  flag = false;
              }
              
            }

        }
    }
 }
