/*
https://www.codewars.com/kata/5168bb5dfe9a00b126000018

8 kyu

Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow'

*/
namespace CodeWars._8_kyu
{
    public class ReversedStrings
    {
        public static string Solution(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
                result += str[i];
            return result;
        }
    }
}
