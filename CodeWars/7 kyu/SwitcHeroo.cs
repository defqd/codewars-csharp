/*
 
https://www.codewars.com/kata/57f759bb664021a30300007d

7 kyu

Given a string made up of letters a, b, and/or c, switch the position of letters a and b (change a to b and vice versa). Leave any incidence of c untouched.

Example:

'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'

*/

using System.Text.RegularExpressions;

namespace CodeWars._7_kyu
{
    public class SwitcHeroo
    {
        public static string Switcheroo(string x)
        {
            return x.Replace("a", "d").Replace("b", "a").Replace("d", "b");

            //return Regex.Replace(x, "[ab]", m => m.Value == "a" ? "b" : "a");

            //var result = "";
            //foreach (var item in x)
            //{
            //    if (item == 'a')
            //        result += 'b';

            //    else if (item == 'b')
            //        result += 'a';

            //    else
            //        result += item;
            //}
            //return result;

            //return new string(x.Select(i => i == 'a' ? i = 'b' : (i == 'b' ? 'a' : i)).ToArray());
        }
    }
}