/*
https://www.codewars.com/kata/596c6eb85b0f515834000049

8 kyu
 
The code provided is supposed replace all the dots . in the specified String str with dashes -

But it's not working properly.

Task
Fix the bug so we can all go home early.

Notes
String str will never be null.
*/
using System.Text.RegularExpressions;

namespace CodeWars._8_kyu
{
    public class ReplaceAllDots
    {
        public static string ReplaceDots(string str)
        {
            return new Regex("\\.").Replace(str, "-");
        }
    }
}
