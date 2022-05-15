/*
https://www.codewars.com/kata/5583090cbe83f4fd8c000051

8 kyu

Convert number to reversed array of digits
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example:
348597 => [7,9,5,8,4,3]
0 => [0]
*/

namespace CodeWars._8_kyu
{
    public class ConvertNumberToArray
    {
        public static int[] Digitize(long n)
        {
            var numbers = n.ToString().ToCharArray().Reverse();
            return numbers.Select(n => n - '0').ToArray();
        }
    }
}
