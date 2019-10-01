using System;


namespace TestClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyPerson Personal = new MyPerson();
            {
                Personal.Color = "Black";
                Console.WriteLine("My Person's Hair Color is: {0}", Personal.Color);
                Console.WriteLine("My Name is:  {0}", Personal.Name);
            }
        }
    }

}



