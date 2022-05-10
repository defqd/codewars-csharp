/*
https://www.codewars.com/kata/57eae65a4321032ce000002d

8 kyu

Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the
resulting string.

Note: input will never be an empty string

*/
namespace CodeWars._8_kyu
{
    public class FakeBinary
    {
        public static string FakeBin(string x)
        {
            char[] c = new char[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                c[i] = x[i] < '5' ? '0' : '1';

            }
            string s1 = new string(c);
            return s1;
        }
    }
}
