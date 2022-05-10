/*
https://www.codewars.com/kata/515e271a311df0350d00000f

8 kyu 

Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
 */
namespace CodeWars._8_kyu
{
    public class KataSquareSum
    {
        public static int SquareSum(int[] n)
        {
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                count += n[i] * n[i];
            }
            return count;
        }
    }
}
