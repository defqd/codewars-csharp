/*
https://www.codewars.com/kata/5966e33c4e686b508700002d

8 kyu

Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string):

Example: (Input1, Input2 -->Output)

"4",  "5" --> "9"
"34", "5" --> "39"
"", "" --> "0"
"2", "" --> "2"
"-5", "3" --> "-2"
Notes:

If either input is an empty string, consider it as zero.

Inputs and the expected output will never exceed the signed 32-bit integer limit (2^31 - 1)

*/
namespace CodeWars._8_kyu
{
    public class SumTheStrings
    {
        public static string StringsSum(string s1, string s2)
        {
            if (String.IsNullOrEmpty(s1))
                s1 = "0";
            if (String.IsNullOrEmpty(s2))
                s2 = "0";
            int result = int.Parse(s1) + int.Parse(s2);
            return result.ToString();
        }
    }
}
