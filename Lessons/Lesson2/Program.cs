using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] reversedMessage = {'!', 'd', 'l', 'r', 'o', 'W', ' ', 'o', 'l', 'l', 'e', 'H'};
            // ...or if you want a challenge, do this (don't copy null characters):
            // char[][] reversedMessage = new char[][] {
            //     new char[] {'\0', '!'},
            //     new char[] {'\0', 'd', 'l', 'r', 'o', 'W'},
            //     new char[] {'\0', ' '},
            //     new char[] {'\0', 'o', 'l', 'l', 'e', 'H'}
            //     };

            char[] result = new char[12];        
            // TODO reverse the message by copying the charecters into the result array in reverse
            // order, then print the result

            Console.WriteLine(result);
        }
    }
}
