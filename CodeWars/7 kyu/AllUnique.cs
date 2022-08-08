/*

7 kuy

https://www.codewars.com/kata/553e8b195b853c6db4000048

Write a program to determine if a string contains only unique characters. Return true if it does and false otherwise.

The string may contain any of the 128 ASCII characters. Characters are case-sensitive, e.g. 'a' and 'A' are considered different characters.

*/
namespace CodeWars._7_kyu
{
    public class AllUnique
    {
        public static bool HasUniqueChars(string str)
        {

            //return new String(str.Distinct().ToArray()).Length < str.Length ? false : true;

            //return str.Distinct().Count() < str.Length ? false : true;

            //return new HashSet<char>(str).Count < str.Length ? false : true;

            //return str.Distinct().SequenceEqual(str);

            //return str.Distinct().Count() == str.Length;

            return string.Concat(str.Distinct()) == str;
        }
    }
}
