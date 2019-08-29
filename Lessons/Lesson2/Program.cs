using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string word in args)
            {
                char[] palindrome = word.ToCharArray();

                bool isPalindrome = true;
                for(int i = 0, j = palindrome.Length - 1; i <= palindrome.Length / 2; i++, j--)
                {
                    if (palindrome[i] != palindrome[j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                Console.WriteLine(isPalindrome ? $"{word} is a palindrome" : $"{word} is not a palindrome.");
            }
        }
    }
}
