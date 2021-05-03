using System;

namespace lambda
{
    /// <summary>
    /// Ignore this class.
    /// </summary>
    public static class MyFunctions
    {
        public static TResult GetResultOfLambda<T, TResult>(this T x, Func<T, TResult> func)
        {
            return func(x);
        }

        public static void ExecuteLambda<T>(this T x, Action<T> action)
        {
            action(x);
        }

        public static bool ExecuteTest<T>(this T thingToTest, Predicate<T> test)
        {
            return test(thingToTest);
        }
    }
}