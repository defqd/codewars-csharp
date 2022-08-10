/*

https://www.codewars.com/kata/57cfdf34902f6ba3d300001e

8 kuy

You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

The returned value must be a string, and have "***" between each of its letters.

You should not remove or add elements from/to the array.

*/
namespace CodeWars._8_kyu
{
    public class SortAndStar
    {
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            char[] c = s[0].ToCharArray();
            return string.Join("***", c);

            //return string.Concat(s.OrderBy(s => s, StringComparer.Ordinal).First().Select(x => x + "***")).TrimEnd('*');

            //return string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());
        }
    }
}
