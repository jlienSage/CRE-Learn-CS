using System;

namespace lambda
{
    public static class MyExamples
    {
        public static void DoTheStuff()
        {
            var myObject = new MyStuff { MyValue = 5 };
            const int c = 4;

            // Statement block lambda (note Func type argument)
            int funcResult = myObject.GetResultOfLambda((MyStuff x) => { // Parameter type and parens are optional
                    // x parameter at runtime is myObject
                    Console.WriteLine($"Value is {x.MyValue}.");
                    // c is captured
                    x.MyValue += c;
                    return x.MyValue;
                });
            Console.WriteLine($"Value after getting result is {funcResult}, which is the same as {myObject.MyValue}.");

            // Expression lambda (note Action type argument)
            myObject.ExecuteLambda(x => x.MyValue++);
            Console.WriteLine($"Vaulue after execute is {myObject.MyValue}.");

            // Predicate with expression lambda (note Predicate type argument)
            var isEven = myObject.ExecuteTest(x => x.MyValue % 2 == 0);
            var message = isEven ? "Value is even."
                            :  "Value is not even.";
            Console.WriteLine(message);
        }
    }

    public class MyStuff
    {
        public int MyValue { get; set; }
    }
}