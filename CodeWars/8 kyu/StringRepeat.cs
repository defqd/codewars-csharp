/*
https://www.codewars.com/kata/57a0e5c372292dd76d000d7e

8 kyu

Write a function called repeatStr which repeats the given string string exactly n times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/
namespace CodeWars._8_kyu
{
    public class StringRepeat
    {
        public static string RepeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }

        //public static string RepeatStr(int n, string s)
        //{
        //    if (string.IsNullOrEmpty(s))
        //        return "";
        //    if (n == 0)
        //        return "";
        //    return s + RepeatStr(n - 1, s);
        //}
    }
}
