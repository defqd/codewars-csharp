/*
https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp

8 kyu

It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're
given one parameter, the original string. You don't have to worry with strings with less than two characters.
*/

namespace CodeWars._8_kyu
{
    public class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
