/*
https://www.codewars.com/kata/51c8991dee245d7ddf00000e

8 kyu

Complete the solution so that it reverses all of the words within the string passed in.

Example:

"The greatest victory is that which requires no battle" --> "battle no requires which that is victory greatest The"

*/
namespace CodeWars._8_kyu
{
    public class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            var values = str.Split(' ');
            Array.Reverse(values);
            return String.Join(' ', values);
        }
    }
}
