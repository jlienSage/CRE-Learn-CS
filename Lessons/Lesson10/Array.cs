
using System;
namespace DataStructure
{
    public partial class Lesson10
    {
        public static void Array()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Array Example: ");
            Console.WriteLine("----------------------------- ");
            // declares an Array of integers. 
            int[] intArray;

            // allocating memory for 5 integers. 
            intArray = new int[5];

            // initialize the first elements 
            // of the array 
            intArray[0] = 10;

            // initialize the second elements 
            // of the array 
            intArray[1] = 20;

            // so on... 
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements 
            // using for loop 
            Console.Write("intArray : ");
            for (int i = 0; i < intArray.Length; i++)
                Console.Write(intArray[i] + " ");

        }
    }
}