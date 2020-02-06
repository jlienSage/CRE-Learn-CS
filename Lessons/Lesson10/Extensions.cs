using System;

namespace DataStructure
{
    public static class Extensions
    {
        public static bool TryCast<T>(this object x, out T result)
        {
            try
            {
                result = (T)x;
            }
            catch(InvalidCastException)
            {
                result = default(T);
                return false;
            }
            return true;
        }
    }
}