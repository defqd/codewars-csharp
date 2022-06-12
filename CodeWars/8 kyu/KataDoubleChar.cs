/*
https://www.codewars.com/kata/56b1f01c247c01db92000076

8 kyu 

Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "
Good Luck!
*/

using System.Text.RegularExpressions;

namespace CodeWars._8_kyu
{
    public class KataDoubleChar
    {
        public static string DoubleChar(string s)
        {
            return Regex.Replace(s, ".", "$&$&");
        }

        //public static string DoubleChar(string s)
        //{
        //    return string.Join("", s.Select(x => "" + x + x));
        //}

        //public static string DoubleChar(string s)
        //{
        //    string result = "";
        //    foreach (var character in s)
        //    {
        //        result += character;
        //        result += character;
        //    }
        //    return result;
        //}
    }
}
