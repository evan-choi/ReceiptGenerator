using System.Linq;

namespace System.Text
{
    public static class StringEx
    {
        public static bool AnyEquals(this string expression, string obj)
        {
            return expression.Equals(obj, StringComparison.OrdinalIgnoreCase);
        }

        public static StringWrapper ToWrapper(this string expression)
        {
            return new StringWrapper(expression);
        }
    }
}
