using System.Linq;

namespace Kata
{
    public class RomanOperations
    {
        public string Add(string left, string right)
        {
            return Normalize(Denormalize(left) + Denormalize(right));
        }

        private static string Denormalize(string roman)
        {
            return roman
                .Replace("IV",  4.Times("I"))
                .Replace( "V",  5.Times("I"))
                .Replace("IX",  9.Times("I"))
                .Replace( "X", 10.Times("I"))
                ;
        }

        private string Normalize(string denormalized)
        {
            return denormalized
                .Replace(40.Times("I"), "XL")
                .Replace(10.Times("I"), "X")
                .Replace( 9.Times("I"), "IX")
                .Replace( 5.Times("I"), "V")
                .Replace( 4.Times("I"), "IV");
        }
    }

    public static class IntExtensions
    {
        public static string Times(this int number, string repeatable)
        {
            return string.Join("", Enumerable.Repeat(repeatable, number));
        }
    }
}